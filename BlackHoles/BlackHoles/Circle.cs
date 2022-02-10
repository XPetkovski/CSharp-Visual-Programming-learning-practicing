using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHoles
{
    [Serializable]
    public abstract class Circle
    {
        private Point Center { get; set; }
        private int Radius { get; set; }
        public Circle(Point Center, int Radius)
        {
            this.Center = Center;
            this.Radius = Radius;
        }

        public abstract void Draw(Graphics g);
        public bool isAlive() =>
            (this.Radius >= 0);

        public bool IsColiding(Circle ball) =>
            ((((this.Center.X - ball.Center.X) * (this.Center.X - ball.Center.X)) + ((this.Center.Y - ball.Center.Y) * (this.Center.Y - ball.Center.Y))) <= ((this.Radius + ball.Radius) * (this.Radius + ball.Radius)));

        public bool isHit(Point p) =>
            ((((this.Center.X - p.X) * (this.Center.X - p.X)) + ((this.Center.Y - p.Y) * (this.Center.Y - p.Y))) <= (this.Radius * this.Radius));

        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveUp();

        public Point Center { get; set; }

        public int Radius { get; set; }
    }
}
