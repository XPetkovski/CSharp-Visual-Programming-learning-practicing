using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public int Radius { get; set; }
        public Circle(Point Center, Color PrimaryColor)
        {
            this.Center = Center;
            this.PrimaryColor = PrimaryColor;
            this.Radius = 50;
            this.SecondaryColor = Color.FromArgb(255 - PrimaryColor.R, 255 - PrimaryColor.G, 255 - PrimaryColor.B);
        }

        public void Draw(Graphics g)
        {
            Brush primary = new SolidBrush(PrimaryColor);
            Brush secondary = new SolidBrush(SecondaryColor);
            g.FillPie(secondary, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2, 0, 180);
            g.FillPie(primary, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2, 180, 180);
            primary.Dispose();
            secondary.Dispose();
        }

        public void Pulse()
        {
            Color temp = PrimaryColor;
            PrimaryColor = SecondaryColor;
            SecondaryColor = temp;
        }
    }
}
