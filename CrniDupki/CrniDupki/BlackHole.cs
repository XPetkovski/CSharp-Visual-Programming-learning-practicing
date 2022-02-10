using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrniDupki
{
    public BlackHole(Point Center, int Radius) : base(Center, Radius)
    {
    }

    public override void Draw(Graphics g)
    {
        Brush brush = new SolidBrush(Color.Black);
        g.FillEllipse(brush, (int)(base.Center.X - base.Radius), (int)(base.Center.Y - base.Radius), (int)(base.Radius * 2), (int)(base.Radius * 2));
        brush.Dispose();
    }

    public override void MoveDown()
    {
        base.Center = new Point(base.Center.X, base.Center.Y + 5);
    }

    public override void MoveLeft()
    {
        base.Center = new Point(base.Center.X - 5, base.Center.Y);
    }

    public override void MoveRight()
    {
        base.Center = new Point(base.Center.X + 5, base.Center.Y);
    }

    public override void MoveUp()
    {
        base.Center = new Point(base.Center.X, base.Center.Y - 5);
    }
}

}
