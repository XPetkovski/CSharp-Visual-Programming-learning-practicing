using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlucajniFormi
{
    [Serializable]
    public class Shape
    {
        public Point Position { get; set; }
        public Color Color { get; set; }
        public Shape(Point p, Color c)
        {
            Position = p;
            Color = c;
        }

        public abstract void draw(Graphics g);
    }
}
