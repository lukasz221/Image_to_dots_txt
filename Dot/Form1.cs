using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot
{
    public partial class Form1 : Form
    {
        DoStuff doStuff;
        Image imageToConvert;
        Bitmap bitmapAfterConvert;
        public Form1()
        {
            InitializeComponent();
            doStuff = new DoStuff();
            doStuff.ImgCreated += OnImgCreated;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Debug.WriteLine($"{path} and {file.FileName}");
                imageToConvert = pictureBoxLoadImg.Image = Image.FromFile(path);
                textBoxImgPath.Text = path;
                buttonMagic.Enabled = true;
                pictureBoxLoadImg.Size = new System.Drawing.Size(imageToConvert.Width, imageToConvert.Height);
                textBoxLog.Text = string.Format("Img added!" + Environment.NewLine);
                if (pictureBoxLoadImg.Size.Width <= 340)
                {
                    this.Size = new Size(360, pictureBoxLoadImg.Size.Height + 160);
                }
                else
                {
                    this.Size = new Size(pictureBoxLoadImg.Size.Width + 40, pictureBoxLoadImg.Size.Height + 160);
                }
            }
        }

        private async void buttonMagic_Click(object sender, EventArgs e)
        {
            bitmapAfterConvert = new Bitmap(imageToConvert);
            string path = Path.GetDirectoryName(textBoxImgPath.Text);
            int size = Int32.Parse(textBoxTest.Text);
            doStuff.ToDots(bitmapAfterConvert, path, size);
        }

        public void OnImgCreated(object s, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Background.wav");
            player.Play();
            textBoxLog.Text = string.Format("Done!"+ Environment.NewLine);
        }
    }
}
