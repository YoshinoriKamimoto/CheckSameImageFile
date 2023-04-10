using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Image image1;
        private Image image2;

        public Form1()
        {
            InitializeComponent();
        }



        // 画像1表示
        private void DrawImg1Button_Click(object sender, EventArgs e)
        {
            // 画像1表示
            using (FileStream fs = File.OpenRead(@"C:\Users\kamimoto\Pictures\img1\sample5.png"))
            {
                image1 = Image.FromStream(fs);
                pictureBox1.Image = image1;
            }
        }


        // 画像2表示
        private void DrawImg2Button_Click(object sender, EventArgs e)
        {
            // 画像2表示
            using (FileStream fs = File.OpenRead(@"C:\Users\kamimoto\Pictures\img1\sample6.png"))
            {
                image2 = Image.FromStream(fs);
                pictureBox2.Image = image2;
            }
        }


        // 画像比較
        private void CompareImgButton_Click(object sender, EventArgs e)
        {
            // 画像1のバイトを取得
            byte[] bytes1;
            using (FileStream fs = File.OpenRead(@"C:\Users\kamimoto\Pictures\img1\sample5.png"))
            {
                bytes1 = new byte[fs.Length];
                fs.Read(bytes1, 0, bytes1.Length);
                int sum = 0;
                foreach (byte b in bytes1)
                {
                    sum += b;
                }
                Console.WriteLine($"バイト合計(画像1)：{sum}");
            }

            // 画像2のバイトを取得
            byte[] bytes2;
            using (FileStream fs = File.OpenRead(@"C:\Users\kamimoto\Pictures\img1\sample6.png"))
            {
                bytes2 = new byte[fs.Length];
                fs.Read(bytes2, 0, bytes2.Length);
                int sum = 0;
                foreach (byte b in bytes2)
                {
                    sum += b;
                }
                Console.WriteLine($"バイト合計(画像2)：{sum}");
            }


            Console.WriteLine($"要素数(画像1):{bytes1.Length}");
            Console.WriteLine($"要素数(画像2):{bytes2.Length}");

            // 画像1,画像2同一ファイル比較
            if (bytes1.Length != bytes2.Length)
            {
                Console.WriteLine("画像不一致");
                MessageBox.Show("画像不一致");
                return;
            }

            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    Console.WriteLine("画像不一致");
                    MessageBox.Show("画像不一致");
                    return;
                }
            }

            Console.WriteLine("画像一致");
            MessageBox.Show("画像一致");

        }


        // 画像削除
        private void DeleteImgButton_Click(object sender, EventArgs e)
        {
            ReleaseImageResource();
        }


        // フォームクローズ
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseImageResource();
        }


        // 画像リソース解放
        private void ReleaseImageResource()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
                pictureBox2.Image = null;
            }

            if (this.image1 != null)
            {
                this.image1.Dispose();
                this.image1 = null;
            }

            if (this.image2 != null)
            {
                this.image2.Dispose();
                this.image2 = null;
            }
        }
    }
}
