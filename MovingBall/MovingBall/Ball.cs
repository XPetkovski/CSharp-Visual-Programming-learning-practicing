using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBall
{
    public class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; set; }
        public float Velocity { get; set; }
        public float VelocityX;
        public float VelocityY;
        public float Angle { get; set; }
        public Rectangle Bounds;
        
        public Ball(float X, float Y, float Radius, float Velocity, float Angle)
        {
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
            this.Velocity = Velocity;
            this.Angle = Angle;
            this.VelocityX = (float)Math.Cos(Angle) * Velocity;
            this.VelocityY = (float)Math.Sin(Angle) * Velocity;
        }

        public void Move()
        {
            float nextX = X + VelocityX;
            float nextY = Y + VelocityY;
            if(nextX - Radius <= Bounds.Left || (nextX + Radius >= Bounds.Right))
            {
                VelocityX = -VelocityX;
            }
            if(nextY - Radius <= Bounds.Top || (nextY+Radius >= Bounds.Bottom))
            {
                VelocityY = -VelocityY;
            }
        }

        public void Draw(Brush brush, Graphics g)
        {
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}
