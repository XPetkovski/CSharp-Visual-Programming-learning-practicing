using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MovingBall
{
    public class Rectangle
    {
        public Int32 Left { get; set; }
        public Int32 Right { get; set; }
        public Int32 Top { get; set; }
        public Int32 Bottom { get; set; }

        public Rectangle(Int32 Left, Int32 Right, Int32 Top, Int32 Bottom)
        {
            this.Left = Left;
            this.Right = Right;
            this.Top = Top;
            this.Bottom = Bottom;
        }
        public void drawRectangle(Brush brush, Graphics g)
        {
            g.FillRectangle(brush, Left, Right, Top, Bottom);
        }
    }
}
