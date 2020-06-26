using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV7_7
{
    public partial class Form1 : Form
    {
        Scene scena;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scena = new Scene();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Aquamarine);
            scena.DrawAll(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                scena.AddShape(e.Location, Scene.SHAPE_TYPE.CIRCLE);
            }
            if(e.Button == MouseButtons.Right)
            {
                scena.AddShape(e.Location, Scene.SHAPE_TYPE.TRIANGLE);
            }
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.Clicked(e.Location);
            Invalidate(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(scena.selectedShape != null)
            {
                if (e.KeyCode == Keys.Up)
                {
                    scena.selectedShape.Location = new Point(scena.selectedShape.Location.X, scena.selectedShape.Location.Y - 10);
                }
                if (e.KeyCode == Keys.Down)
                {
                    scena.selectedShape.Location = new Point(scena.selectedShape.Location.X, scena.selectedShape.Location.Y + 10);
                }
                if (e.KeyCode == Keys.Left)
                {
                    scena.selectedShape.Location = new Point(scena.selectedShape.Location.X - 10, scena.selectedShape.Location.Y);
                }
                if (e.KeyCode == Keys.Right)
                {
                    scena.selectedShape.Location = new Point(scena.selectedShape.Location.X + 10, scena.selectedShape.Location.Y);
                }
            }
            Invalidate();
        }

        private void startTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scena.Pulse();
            Invalidate();
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if(d.ShowDialog() == DialogResult.OK)
            {
                scena.currentcolor = d.Color;
            }
            Invalidate();
        }
    }
}
