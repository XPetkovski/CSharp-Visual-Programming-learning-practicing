using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Pacman
    {
        public enum DIRECTION { UP, DOWN, RIGHT, LEFT};
        public float X { get; set; }
        public float Y { get; set; }
        public string dir { get; set; }
        static public int radius = 20;
        public double speed { get; set; }
        public bool open { get; set; }
        public Brush brush = new SolidBrush(Color.Yellow);

        public Pacman()
        {
            this.X = 7;
            this.Y = 5;
            this.speed = 20;
            this.dir = Convert.ToString(DIRECTION.RIGHT);
            this.open = false;
        }

        public void ChangeDirection(string direction)
        {
            for(int i = 0; i<3; i++)
            {
                if(direction == Convert.ToString(DIRECTION.RIGHT))
                {
                    dir = "RIGHT";
                }
                if (direction == Convert.ToString(DIRECTION.LEFT))
                {
                    dir = "LEFT";
                }
                if (direction == Convert.ToString(DIRECTION.UP))
                {
                    dir = "UP";
                }
                if (direction == Convert.ToString(DIRECTION.DOWN))
                {
                    dir = "DOWN";
                }
            }
        }

        public void Move(float width, float height)
        {
            if(dir == Convert.ToString(DIRECTION.RIGHT))
            {
                X += 1;
                if(X > width)
                {
                    X = 1;
                }
            }

            if(dir == Convert.ToString(DIRECTION.LEFT))
            {
                X -= 1;
                if(X < width)
                {
                    X = 14;
                }
            }
            if(dir == Convert.ToString(DIRECTION.UP))
            {
                Y += 1;
                if(Y > height)
                {
                    Y = 1;
                }
            }
            if(dir == Convert.ToString(DIRECTION.DOWN))
            {
                Y -= 1;
                if(Y < height)
                {
                    Y = 14;
                }
            }
        }

        public void Draw(Graphics g)
        {
            if(!open)
            {
                g.FillEllipse(brush, 7, 5, 15, 15);
            }
        }
    }
}
