using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV9
{
    [Serializable]
    public class Scene
    {
        public List<Polygon> Polygons { get; set; }
        private Polygon CurrentPolygon { get; set; }
        private Point FirstPoint { get; set; }
        private Point CurrentPoint { get; set; }

        private bool IsHit { get; set; }

        public Scene()
        {
            Polygons = new List<Polygon>();
            FirstPoint = Point.Empty;
            IsHit = false;
            //CurrentPolygon = null;
            //CurrentPoint = null;
        }

        public void Click(Point Location)
        {
            if(FirstPoint.IsEmpty)
            {
                FirstPoint = Location;
                CurrentPolygon = new Polygon();
                CurrentPolygon.AddPoint(Location);
            }
            else
            {
                CurrentPolygon.AddPoint(Location);
                if(IsHit)
                {
                    CurrentPolygon.isCompleted = true;
                    Polygons.Add(CurrentPolygon);
                    FirstPoint = Point.Empty;
                    CurrentPolygon = null;
                }
            }
        }

        public void Move(Point Location)
        {
            CurrentPoint = Location;
            IsHit = false;
            if(CurrentPolygon != null && CurrentPolygon.Points.Count > 2)
            {
                IsHit = Distance(CurrentPoint, FirstPoint) < 5 * 5;
            }
        }

        private int Distance(Point A, Point B)
        {
            return (A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y);
        }

        public void Draw(Graphics g)
        {
            //site poligoni veke kompletirani
            foreach(Polygon p in Polygons)
            {
                p.Draw(g);
            }
            Pen pen = new Pen(Color.Black, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //momentalniot poligon dokolku postoi
            if (CurrentPolygon != null)
            {
                CurrentPolygon.Draw(g);
            }
            //momentalen poligon dokolku postoi i isprekinata linija do momentalna tocka
            if(CurrentPolygon != null)
            {
                CurrentPolygon.Draw(g);
                g.DrawLine(pen, CurrentPolygon.LastPoint(), CurrentPoint);
            }
            //
            if(!FirstPoint.IsEmpty && IsHit)
            {
                g.DrawEllipse(pen, FirstPoint.X - 5, FirstPoint.Y - 5, 10, 10);
            }
            pen.Dispose();
        }
    }
}
