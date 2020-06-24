using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje5._5
{
    public interface IUpdatableView
    {
        void UpdateView();
    }
    public partial class Form1 : Form, IUpdatableView
    {
        Coins coinsDoc;
        ControllerForm Controller;

        public Form1(Coins _coinsDoc, ControllerForm ctrl)
        {
            InitializeComponent();
            coinsDoc = _coinsDoc;
            Controller = ctrl;
        }

        public void UpdateView()
        {
            Invalidate(true);
        }

        public Form1()
        {
            InitializeComponent();
            coinsDoc = new Coins();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.Gold);
            Pen pn = new Pen(Color.Black, 1);
            Graphics canvas = panel1.CreateGraphics();
            canvas.Clear(Color.White);
            for(int nCount = 0; nCount < coinsDoc.NumCoins; nCount++)
            {
                int y = panel1.Size.Height - 50 - 10 * nCount;
                canvas.FillEllipse(br, 40, y, 100, 30);
                canvas.DrawEllipse(pn, 40, y, 100, 30);
                canvas.FillEllipse(br, 40, y, 100, 30);
                canvas.DrawEllipse(pn, 40, y, 100, 30);
            }
            pn.Dispose();
            br.Dispose();
        }

        private void addACoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.addOne();
            //Invalidate(true);
        }

        private void removeACoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.removeOne();
            //Invalidate(true);
        }

        private void add2CoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.addTwo();
            //Invalidate(true);
        }

        private void statusLabel1_Paint(object sender, PaintEventArgs e)
        {
            statusLabel1.Text = "#coins: " + coinsDoc.NumCoins.ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //Invalidate(true);
            UpdateView();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.RemoveView(this);
        }
    }
}
