using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Dot
{
    internal class DoStuff
    {
        private Bitmap img;
        private Bitmap grayBitmap;
        private Bitmap resized;

        public delegate void ImgCreatedEventHandler(object source, EventArgs args);
        public event ImgCreatedEventHandler ImgCreated;
        public async Task ToDots(Bitmap _img, string _path, int _size)
        {
            img = _img;
            string pathAndName;
            grayBitmap = GrayScaleFilter(img);
            resized = new Bitmap(grayBitmap, new Size(grayBitmap.Width / _size, grayBitmap.Height / _size));
            string name = "dots.txt";
            string path = Path.Combine(_path, name);
            int h = resized.Height;
            int w = resized.Width;
            Debug.WriteLine($"Img Height: {h} Img Width: {w}");
            Debug.WriteLine( "PATH: " + path);
            if (!File.Exists(path)) ;
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    for (int i = 0; i < h; i++)
                    {
                        await sw.WriteLineAsync();
                        for (int j = 0; j < w; j++)
                        {
                            Color pixel = resized.GetPixel(j, i);
                            if (pixel.GetBrightness() <= 0.16)
                            {
                                //Debug.WriteLine($"Pixel color: {pixel} Img Height: {i} Img Width: {j} w:{w}h:{h}");
                                await sw.WriteAsync(String.Format("█"));
                            }
                            else if (pixel.GetBrightness() <= 0.32)
                            {
                                //Debug.WriteLine($"Pixel color: {pixel} Img Height: {i} Img Width: {j} w:{w}h:{h}");
                                await sw.WriteAsync(String.Format("▓"));
                            }
                            else if (pixel.GetBrightness() <= 0.48)
                            {
                                //Debug.WriteLine($"Pixel color: {pixel} Img Height: {i} Img Width: {j} w:{w}h:{h}");
                                await sw.WriteAsync(String.Format("▒"));
                            }
                            else if (pixel.GetBrightness() <= 0.64)
                            {
                                //Debug.WriteLine($"Pixel color: {pixel} Img Height: {i} Img Width: {j} w:{w}h:{h}");
                                await sw.WriteAsync(String.Format("░"));
                            }
                            else if (pixel.GetBrightness() <= 0.80)
                            {
                                //Debug.WriteLine($"Pixel color: {pixel} Img Height: {i} Img Width: {j} w:{w}h:{h}");
                                await sw.WriteAsync(String.Format("."));
                            }
                            else
                            {
                                //Debug.WriteLine($"Pixel color: {pixel} Img Height: {i} Img Width: {j}  w:{w}h:{h}");
                                await sw.WriteAsync(String.Format(" "));
                            }

                        }
                    }
                }
                OnImgCreated();
                OpenWithDefaultProgram(path);


            }
        }

        public Bitmap GrayScaleFilter(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
            {
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = image.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            }

            return grayScale;
        }

        public static void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        protected virtual void OnImgCreated()
        {
            if (ImgCreated != null)
            {
                ImgCreated(this, null);
            }
        }
    }
}
