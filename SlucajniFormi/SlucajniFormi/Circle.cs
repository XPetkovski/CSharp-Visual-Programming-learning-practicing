using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlucajniFormi
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Circle()//int Radius, Point Center)
        {
            //this.Radius = Radius;
            //this.Center = Center;
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }
    }
}
