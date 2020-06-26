using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7_7
{
    public abstract class Shape
    {
        public Point Location { get; set; }
        public Color color { get; set; }
        public bool isSelected { get; set; }
        public Shape(Point Location, Color color)
        {
            this.Location = Location;
            this.color = color;
            isSelected = false;
        }
        public abstract void Draw(Graphics g);
        public abstract bool Clicked(Point lok);
        public abstract void Pulse();
    }
}
