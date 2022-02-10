using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrniDupki
{
    public class Scene
    {
        // Methods
        public Scene()
        {
            this.Circles = new List<RedCircle>();
            this.FirstPoint = Point.Empty;
            this.SecondPoint = Point.Empty;
        }

        private bool checkCollisions(Circle redCircle)
        {
            using (List<RedCircle>.Enumerator enumerator = this.Circles.GetEnumerator())
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    RedCircle current = enumerator.Current;
                    if (current.IsColiding(redCircle))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Click(Point p)
        {
            if (this.FirstPoint.IsEmpty)
            {
                this.FirstPoint = p;
            }
            else if (this.SecondPoint.IsEmpty)
            {
                this.SecondPoint = p;
                RedCircle redCircle = new RedCircle(this.FirstPoint, this.distance(this.FirstPoint, this.SecondPoint));
                if (!this.checkCollisions(redCircle))
                {
                    this.Circles.Add(redCircle);
                }
                this.FirstPoint = Point.Empty;
                this.SecondPoint = Point.Empty;
            }
        }

        internal void deleteCollided()
        {
            foreach (RedCircle circle in this.Circles)
            {
                if (circle.IsColiding(this.BlackHole))
                {
                    circle.deleteFlag = true;
                }
            }
            for (int i = this.Circles.Count - 1; i >= 0; i--)
            {
                if (this.Circles[i].deleteFlag)
                {
                    this.Circles.RemoveAt(i);
                    this.BlackHole.Radius = (int)(this.BlackHole.Radius * 1.1);
                }
            }
        }

        private int distance(Point p1, Point p2) =>
            ((int)Math.Sqrt((double)(((p1.X - p2.X) * (p1.X - p2.X)) + ((p1.Y - p2.Y) * (p1.Y - p2.Y)))));

        internal void DoubleClick(Point location)
        {
            if ((this.Circles.Count >= 5) && ReferenceEquals(this.BlackHole, null))
            {
                CrniDupki redCircle = new CrniDupki(location, 50);
                if (!this.checkCollisions(redCircle))
                {
                    this.BlackHole = redCircle;
                }
            }
        }

        public void drawAll(Graphics g)
        {
            foreach (RedCircle circle in this.Circles)
            {
                circle.Draw(g);
            }
            if (this.BlackHole != null)
            {
                this.BlackHole.Draw(g);
            }
        }

        internal void MoveDown()
        {
            if (this.BlackHole != null)
            {
                this.BlackHole.MoveDown();
            }
        }

        internal void MoveLeft()
        {
            if (this.BlackHole != null)
            {
                this.BlackHole.MoveLeft();
            }
        }

        internal void MoveRight()
        {
            if (this.BlackHole != null)
            {
                this.BlackHole.MoveRight();
            }
        }

        internal void MoveUp()
        {
            if (this.BlackHole != null)
            {
                this.BlackHole.MoveUp();
            }
        }

        internal void reduceBlackHole()
        {
            if (this.BlackHole != null)
            {
                CrniDupki blackHole = this.BlackHole;
                blackHole.Radius -= 2;
            }
        }

        internal bool shouldGameEnd() =>
            (((this.BlackHole == null) || this.BlackHole.isAlive()) ? (this.Circles.Count == 0) : true);

        public List<RedCircle> Circles { get; set; }

        public CrniDupki BlackHole { get; set; }

        public Point FirstPoint { get; set; }

        public Point SecondPoint { get; set; }
    }

}
