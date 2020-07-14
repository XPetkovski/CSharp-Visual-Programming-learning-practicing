using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9___Serijalizacija
{
    public class Circle : Shape
    {
        public static int Radius = 25;
        public Circle(Point location, Color color) : base(location,color)
        {

        }

        public override bool Clicked(Point kliknata_lokacija)
        {
            return ((kliknata_lokacija.X - location.X) * (kliknata_lokacija.X - location.X)) + ((kliknata_lokacija.Y - location.Y) *
                (kliknata_lokacija.Y - location.Y)) <= Radius * Radius;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            Pen p = new Pen(Color.Indigo, 4);
            g.DrawEllipse(p, location.X, location.Y, Radius * 2, Radius * 2);
            g.FillEllipse(b, location.X, location.Y, Radius * 2, Radius * 2);
            b.Dispose();
        }
    }
}
