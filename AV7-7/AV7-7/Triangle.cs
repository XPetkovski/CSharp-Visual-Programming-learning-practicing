using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7_7
{
    public class Triangle : Shape
    {
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Triangle(Point Location, Color color, Point P2, Point P3) : base(Location,color)
        {
            this.P2 = P2;
            this.P3 = P3;
        }
        public override bool Clicked(Point lok)
        {
            return false;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            Point[] niza = new Point[3];
            niza[0] = Location;
            niza[1] = P2;
            niza[2] = P3;
            g.FillPolygon(b, niza);
            b.Dispose();
        }

        public override void Pulse()
        {
            
        }
    }
}
