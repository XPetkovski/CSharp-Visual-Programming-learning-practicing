using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlucajniFormi
{
    [Serializable]
    public class Rectangle
    {
        private Random random;
        int w;
        int h;
        public int strana { get; set; }
        public Rectangle(Point p, int w, int h) : base(p, Color.Green)
        {
            random = new Random();
            strana = random.Next(10, 50);
            this.w = w;
            this.h = h;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, Position.X, Position.Y, strana, strana);
            brush.Dispose();
        }
    }
}
