using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV8
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public float Thickness { get; set; }
        public Color color { get; set; }

        public Line(Point Start, Point End, float Thickness, Color color)
        {
            this.Start = Start;
            this.End = End;
            this.Thickness = Thickness;
            this.color = color;
        }

        public void draw(Graphics g)
        {
            Pen pn = new Pen(color, Thickness);
            g.DrawLine(pn, Start, End);
            pn.Dispose();
        }

        public void move(int dx, int dy)
        {
            Start = new Point(Start.X + dx, Start.Y + dy);
            End = new Point(End.X + dx, End.Y + dy);
        }
    }
}
