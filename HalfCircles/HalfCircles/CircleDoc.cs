using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> circles { get; set; }

        public CircleDoc()
        {
            circles = new List<Circle>();
        }

        public void AddCircle(Point center, Color color)
        {
            circles.Add(new Circle(center, color));
        }

        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }

        public void Pulse()
        {
            foreach(Circle c in circles)
            {
                c.Pulse();
            }
        }
    }
}
