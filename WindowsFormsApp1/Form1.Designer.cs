namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawImg1Button = new System.Windows.Forms.Button();
            this.DrawImg2Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DeleteImgButton = new System.Windows.Forms.Button();
            this.CompareImgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawImg1Button
            // 
            this.DrawImg1Button.Location = new System.Drawing.Point(145, 49);
            this.DrawImg1Button.Name = "DrawImg1Button";
            this.DrawImg1Button.Size = new System.Drawing.Size(75, 23);
            this.DrawImg1Button.TabIndex = 0;
            this.DrawImg1Button.Text = "画像1";
            this.DrawImg1Button.UseVisualStyleBackColor = true;
            this.DrawImg1Button.Click += new System.EventHandler(this.DrawImg1Button_Click);
            // 
            // DrawImg2Button
            // 
            this.DrawImg2Button.Location = new System.Drawing.Point(452, 49);
            this.DrawImg2Button.Name = "DrawImg2Button";
            this.DrawImg2Button.Size = new System.Drawing.Size(75, 23);
            this.DrawImg2Button.TabIndex = 1;
            this.DrawImg2Button.Text = "画像2";
            this.DrawImg2Button.UseVisualStyleBackColor = true;
            this.DrawImg2Button.Click += new System.EventHandler(this.DrawImg2Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(350, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // DeleteImgButton
            // 
            this.DeleteImgButton.Location = new System.Drawing.Point(293, 381);
            this.DeleteImgButton.Name = "DeleteImgButton";
            this.DeleteImgButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteImgButton.TabIndex = 4;
            this.DeleteImgButton.Text = "画像削除";
            this.DeleteImgButton.UseVisualStyleBackColor = true;
            this.DeleteImgButton.Click += new System.EventHandler(this.DeleteImgButton_Click);
            // 
            // CompareImgButton
            // 
            this.CompareImgButton.Location = new System.Drawing.Point(293, 352);
            this.CompareImgButton.Name = "CompareImgButton";
            this.CompareImgButton.Size = new System.Drawing.Size(75, 23);
            this.CompareImgButton.TabIndex = 5;
            this.CompareImgButton.Text = "画像比較";
            this.CompareImgButton.UseVisualStyleBackColor = true;
            this.CompareImgButton.Click += new System.EventHandler(this.CompareImgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 462);
            this.Controls.Add(this.CompareImgButton);
            this.Controls.Add(this.DeleteImgButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DrawImg2Button);
            this.Controls.Add(this.DrawImg1Button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawImg1Button;
        private System.Windows.Forms.Button DrawImg2Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DeleteImgButton;
        private System.Windows.Forms.Button CompareImgButton;
    }
}

