using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9___Serijalizacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics circle = e.Graphics;
            Brush br = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Indigo, 4);
            circle.DrawEllipse(p, 50, 50, 200, 200);
            circle.FillEllipse(br, 50, 50, 200, 200);
            circle.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
