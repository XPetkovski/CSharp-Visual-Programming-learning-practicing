using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV8
{
    public partial class Form1 : Form
    {
        Scene scena { get; set; }
        public bool positioner { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            scena = new Scene(Width, Height);
            DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.AddLine(new Point(e.X, e.Y));
            Invalidate();
            toolStripStatusLabelLinesCount.Text = string.Format("Lines: {0}", scena.LinesCount());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.DrawAll(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelCurrentPosition.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
            scena.CurrentPoint = new Point(e.X, e.Y);
            Invalidate(true);
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e) //thin
        {
            scena.Thickness = 1;
            thinToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
            thiccToolStripMenuItem.Checked = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scena.Thickness = 2;
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
            thiccToolStripMenuItem.Checked = false;
        }

        private void thiccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scena.Thickness = 3;
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            thiccToolStripMenuItem.Checked = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                scena.Color = cd.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scena.Undo();
            toolStripStatusLabelLinesCount.Text = string.Format("Lines: {0}", scena.LinesCount());
            Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scena.Redo();
            toolStripStatusLabelLinesCount.Text = string.Format("Lines: {0}", scena.LinesCount());
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                scena.Move(0, -5);
            }
            else if(e.KeyCode == Keys.Down)
            {
                scena.Move(0, 5);
            }
            else if(e.KeyCode == Keys.Left)
            {
                scena.Move(-5, 0);
            }
            else if(e.KeyCode == Keys.Right)
            {
                scena.Move(5, 0);
            }
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scena = new Scene(Width , Height);
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(positionerToolStripMenuItem.Checked)
            {
                positionerToolStripMenuItem.Checked = false;
                scena.Positioner = false;
            }
            else
            {
                positionerToolStripMenuItem.Checked = true;
                scena.Positioner = true;
            }
        }
    }
}
