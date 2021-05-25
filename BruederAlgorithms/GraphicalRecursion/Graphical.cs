using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BruederAlgorithms.GraphicalRecursion
{
    public class Graphical
    {
        public Bitmap image;
        public string Name { get; set; }
        public int Wight { get; set; }
        public int Height { get; set; }
        
        public Graphical(int sizeW, int sizeH, string Name = "test")
        {
            image = new Bitmap(sizeW, sizeH);
            this.Wight = sizeW;
            this.Height = sizeH;
            this.Name = Name;
        }
        
        public void Save()
        {
            image.Save(this.Name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }


        public delegate void DrawSquareDelegate(int x, int y, int wight = 200);
        public void DrawRectangleWrapping(int x, int y, DrawSquareDelegate drawSquareDelegate, int wight = 200)
        {
            Pen pen = new Pen(Color.Red, 2);
            using (Graphics g = Graphics.FromImage(this.image))
            {
                g.DrawRectangle(pen, x - wight / 10, y - wight / 10, wight - wight / 3, wight - wight / 3);
            }

            drawSquareDelegate(x, y, wight);
        }
    }
}
