using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlucajniFormi
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> circles { get; set; }
        public enum ShapeType
        {
            CIRCLE,
            RECTANGLE
        }
        public CircleDoc()
        {
            circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }

        public void AddCircle(Point center, Color color)
        {
            circles.Add(new Circle(center,color));
        }
    }
}
