using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AV10
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        //state 0 - zeleno 1 - plavo 2 - crveno -1 - nadvor od ekran 3 - za brisenje
        public int State { get; set; }
        public static int Radius = 40;
        static Random r = new Random();
        public Ball(Point Center)
        {
            Random r = new Random();
            State = r.Next(3);
            this.Center = Center;
        }
        public void Draw(Graphics g)
        {
            if(State == 0)
            {
                Brush brush = new SolidBrush(Color.Green);
                g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
            if (State == 1)
            {
                Brush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
            if (State == 2)
            {
                Brush brush = new SolidBrush(Color.Red);
                g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
        public bool IsHit(int x , int y)
        {
            var diff = (Center.X - x) * (Center.X - x) + (Center.Y - y) * (Center.Y - y);
            return diff <= Radius * Radius;
        }
        public void Move(Point newCenter)
        {
            Center = newCenter;
        }
    }
}
