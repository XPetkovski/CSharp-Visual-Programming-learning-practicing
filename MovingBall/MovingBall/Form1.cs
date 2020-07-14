using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBall
{
    public partial class Form1 : Form
    {
        Ball Ball;
        Timer timer;
        Graphics graphics;
        Brush brush;
        Pen pen;
        Rectangle bounds;
        Bitmap doublebuffer;
        static readonly int FPS = 30;
        public Form1()
        {
            InitializeComponent();
            bounds = new Rectangle(10, 10, this.Bounds.Width - 40, this.Bounds.Height - 60);
            doublebuffer = new Bitmap(Width, Height);
            graphics = CreateGraphics();
            Ball = new Ball(Width / 2, Height / 2, 20, 10, (float)(Math.PI / 4));
            Ball.Bounds = bounds;
            Show();
            brush = new SolidBrush(Color.Indigo);
            pen = new Pen(Color.Red);
            timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000 / FPS;
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(doublebuffer);
            g.Clear(Color.White);
            g.DrawRectangle(pen, bounds);
            Ball.Draw(brush, g);
            Ball.Move();
            graphics.DrawImageUnscaled(doublebuffer, 0, 0);
        }
    }
}
