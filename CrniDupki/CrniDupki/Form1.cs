using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrniDupki
{
    public partial class Form1 : Form
    {
        private IContainer components = null;
        private Timer timer1;

 
        public Form1()
        {
            this.InitializeComponent();
            this.scene = new Scene();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.scene.MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                this.scene.MoveDown();
            }
            if (e.KeyCode == Keys.Left)
            {
                this.scene.MoveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                this.scene.MoveRight();
            }
            this.scene.deleteCollided();
            base.Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.scene.Click(e.Location);
            this.DoubleBuffered = true;
            base.Invalidate();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.scene.DoubleClick(e.Location);
            base.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.scene.drawAll(e.Graphics);
        }

        private void InitializeComponent()
        {
//            this.components = new Container();
//            this.timer1 = new Timer(this.components);
            base.SuspendLayout();
//            this.timer1.Enabled = true;
//            this.timer1.Interval = 0x7d0;
//            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            base.AutoScaleDimensions = new SizeF(8f, 0x10f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x516, 0x2cc);
            base.Name = "Form1";
            this.Text = "Form1";
            base.Paint += new PaintEventHandler(this.Form1_Paint);
            base.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
            base.MouseClick += new MouseEventHandler(this.Form1_MouseClick);
            base.MouseDoubleClick += new MouseEventHandler(this.Form1_MouseDoubleClick);
            base.ResumeLayout(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.scene.reduceBlackHole();
            base.Invalidate();
            if (this.scene.shouldGameEnd())
            {
                this.scene = new Scene();
            }
        }

        // Properties
        public Scene scene { get; set; }
    }

}
}
