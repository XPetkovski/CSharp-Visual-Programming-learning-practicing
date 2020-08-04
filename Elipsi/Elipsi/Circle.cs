using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
    [Serializable]
    public class Circle
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public Point point { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Circle(Point point, int Width, int Height)
        {
            this.point = point;
            this.Width = Width;
            this.Height = Height;
            Random r = new Random();
            R = r.Next(256);
            G = r.Next(256);
            B = r.Next(256);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(R, G, B));
            g.FillEllipse(b, point.X, point.Y, Width, Height);
        }

        public void ChangeColor()
        {
            Random r = new Random();
            R += 5;
            G += 10;
            B += 15;
            R = R % 256;
            G = G % 256;
            B = B % 256;
        }
    }
}
