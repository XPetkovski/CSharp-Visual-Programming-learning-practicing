using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7_7
{
    public class Circle : Shape
    {
        public static int Radius = 25;
        public bool DaliSeZbolemuva { get; set; }
        public Circle(Point Location, Color color) : base(Location, color) 
        {
            DaliSeZbolemuva = false;
        }
        public override bool Clicked(Point kliknata_lokacija)
        {
            //evklidovo rastojanie?
            return ((kliknata_lokacija.X - Location.X) * (kliknata_lokacija.X - Location.X)) + ((kliknata_lokacija.Y - Location.Y) *
                (kliknata_lokacija.Y - Location.Y)) <= Radius * Radius;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            if(isSelected==true)
            {
                Pen p = new Pen(Color.Yellow, 4);
                g.DrawEllipse(p, Location.X, Location.Y, Radius * 2, Radius * 2);
            }
            g.FillEllipse(b, Location.X, Location.Y, Radius*2, Radius*2);
            b.Dispose();
        }

        public override void Pulse()
        {
            if (DaliSeZbolemuva == true)
            {
                Radius += 3;
                if(Radius>80)
                {
                    DaliSeZbolemuva = false;
                }
            }
            else
            {
                Radius -= 3;
                if (Radius <= 25)
                {
                    DaliSeZbolemuva = true;
                }
                
            }
        }
    }
}
