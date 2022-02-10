using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlucajniFormi
{
    [Serializable]
    public class Circle : Shape
    {
        public int Radius { get; set; }
        //public Point Center { get; set; }
        private Random random;

        public Circle(Point p) : base(p, Color.Red)//int Radius, Point Center)
        {
            random = new Random();
            Radius = random.Next(30, 100);
            //this.Radius = Radius;
            //this.Center = Center;
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }
    }
}
