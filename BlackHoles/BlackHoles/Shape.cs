using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHoles
{
    public abstract class Shape
    {
        public Point location { get; set; }
        public Color color { get; set; }
        public Shape(Point location, Color color)
        {
            this.location = location;
            this.color = color;
        }

        public abstract void Draw(Graphics g);
        public abstract bool Clicked(Point look);
    }
}
