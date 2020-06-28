using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV10
{
    [Serializable]
    public class BallDoc
    {
        private static int velocity = 10;
        public int Width { get; set; }
        public List<Ball> Balls;
        public int Hits { get; set; }
        public int Missess { get; set; }
        public BallDoc(int Width)
        {
            Balls = new List<Ball>();
            Hits = 0;
            Missess = 0;
            this.Width = Width;
        }
        public void AddBall(Ball b)
        {
            Balls.Add(b);
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in Balls)
            {
                b.Draw(g);
            }
        }
        public void move()
        {
            foreach (Ball b in Balls.ToList<Ball>())
            {
                b.Move(new Point(b.Center.X+velocity, b.Center.Y));
                if(b.Center.X+Ball.Radius>Width)
                {
                    b.State = -1;
                    Missess++;
                }
                for(int i=0; i<Balls.Count;i++)
                {
                    if(Balls[i].State == -1)
                    {
                        Balls.RemoveAt(i);
                    }
                }
            }
        }

        public void CheckHit(int x, int y)
        {
            for( int i=0; i<Balls.Count;i++)
            {
                if(Balls[i].IsHit(x,y))
                {
                    Balls[i].State++;
                }
            }
            for (int i = 0; i < Balls.Count; i++)
            {
                if (Balls[i].State == 3)
                {
                    Hits++;
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
