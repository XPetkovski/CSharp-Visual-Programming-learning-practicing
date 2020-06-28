using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV9
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public bool isCompleted { get; set; }
        private Color color { get; set; }

        public Polygon()
        {
            Points = new List<Point>();
            color = Color.Indigo;
            isCompleted = false;
        }

        public void AddPoint(Point newPoint)
        {
            Points.Add(newPoint);
        }
        public void Draw(Graphics g)
        {
            if(Points.Count < 2)
            {
                return;
            }
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(color);
            if (isCompleted)
            {
                g.FillPolygon(brush, Points.ToArray());
                //g.DrawPolygon(Pen, Points.ToArray());
            }
            else
            {
                //for(int i = 0; i<=Points.Count-1;i++)
                //{
                //    g.DrawLine(pen, Points[i], Points[i + 1]);
                //}
                g.DrawLines(pen, Points.ToArray());
            }
            pen.Dispose();
            brush.Dispose();
        }

        public Point LastPoint()
        {
            return Points[Points.Count-1];
        }
    }
}
