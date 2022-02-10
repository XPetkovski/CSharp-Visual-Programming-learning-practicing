using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlucajniFormi
{
    [Serializable]
    public class Scene
    {
        public List<Shape> shapes { get; set; }
        public int Checked { get; set; }
        private Random random;
        int w;
        int h;
        private Color[] c = { Color.Red, Color.Blue, Color.Green };
        private int tmp = 0;
        public Scene(int w, int h)
        {
            shapes = new List<Shape>();
            Checked = 1;
            random = new Random();
            this.w = w;
            this.h = h;
        }

        public void AddShape()
        {
            int n = random.Next(3, 10);
            shapes.Clear();
            for( int i=0; i<n; i++)
            {
                if( checked == 1 )
                {
                    Circle c = new Circle(new Point(random.Next(w), random.Next(h)));
                    shapes.Add(c);
                }
                else if(checked == 2)
                {
                    Rectangle r = new Rectangle(new Point(random.Next(w), random.Next(h)), w, h);
                    shapes.Add(r);
                }
            }
        }

        public void drawShapes(Graphics g)
        {
            foreach(Shape s in shapes)
            {
                s.draw(g);
            }
        }

        public void changeColor()
        {
            foreach(Shape s in shapes)
            {
                s.Color = c[tmp];
            }
            tmp++;
            if(tmp == 3)
            {
                tmp = 0;
            }
        }
    }
}
