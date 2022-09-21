namespace Dot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.pictureBoxLoadImg = new System.Windows.Forms.PictureBox();
            this.textBoxImgPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonMagic = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(12, 444);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(285, 86);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(45, 23);
            this.textBoxTest.TabIndex = 1;
            this.textBoxTest.Text = "2";
            // 
            // pictureBoxLoadImg
            // 
            this.pictureBoxLoadImg.Location = new System.Drawing.Point(12, 114);
            this.pictureBoxLoadImg.Name = "pictureBoxLoadImg";
            this.pictureBoxLoadImg.Size = new System.Drawing.Size(318, 324);
            this.pictureBoxLoadImg.TabIndex = 2;
            this.pictureBoxLoadImg.TabStop = false;
            // 
            // textBoxImgPath
            // 
            this.textBoxImgPath.Location = new System.Drawing.Point(12, 27);
            this.textBoxImgPath.Name = "textBoxImgPath";
            this.textBoxImgPath.ReadOnly = true;
            this.textBoxImgPath.Size = new System.Drawing.Size(318, 23);
            this.textBoxImgPath.TabIndex = 3;
            this.textBoxImgPath.Text = "Add Image.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Path:";
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(174, 56);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddImage.TabIndex = 5;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonMagic
            // 
            this.buttonMagic.Enabled = false;
            this.buttonMagic.Location = new System.Drawing.Point(255, 56);
            this.buttonMagic.Name = "buttonMagic";
            this.buttonMagic.Size = new System.Drawing.Size(75, 23);
            this.buttonMagic.TabIndex = 6;
            this.buttonMagic.Text = "Go";
            this.buttonMagic.UseVisualStyleBackColor = true;
            this.buttonMagic.Click += new System.EventHandler(this.buttonMagic_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 56);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(156, 53);
            this.textBoxLog.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resize multiplayer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 117);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonMagic);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImgPath);
            this.Controls.Add(this.pictureBoxLoadImg);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.buttonTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Dot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;
        public System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.PictureBox pictureBoxLoadImg;
        private System.Windows.Forms.TextBox textBoxImgPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonMagic;
        public System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label2;
    }
}
