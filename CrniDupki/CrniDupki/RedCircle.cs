using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrniDupki
{
    public class RedCircle : Circle
    {
        public RedCircle(Point Center, int Radius) : base(Center, Radius)
        {
            this.deleteFlag = false;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, (int)(base.Center.X - base.Radius), (int)(base.Center.Y - base.Radius), (int)(base.Radius * 2), (int)(base.Radius * 2));
            brush.Dispose();
        }

        public override void MoveDown()
        {
        }

        public override void MoveLeft()
        {
        }

        public override void MoveRight()
        {
        }

        public override void MoveUp()
        {
        }

        public bool deleteFlag { get; set; }
    }


}
