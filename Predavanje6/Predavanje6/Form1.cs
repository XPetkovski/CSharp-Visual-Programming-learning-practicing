using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBillView childForm = new FormBillView();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void newCoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCoinView childForm = new FormCoinView();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Coin or Bill file (*.coi;*.bil)|*.coi;*.bil|Coin file(*.coi) | *.coi | Bill file(*.bil) | *.bil";
            openFileDialog1.Title = "Open a Coin or Bill File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".coi")
                {
                    FormCoinView childForm = new FormCoinView(this,
                    openFileDialog1.FileName);
                    if (childForm.FileName == null) childForm.Dispose();
                    else childForm.Show();
                }
                else if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".bil")
                {
                    FormBillView childForm = new FormBillView(this,
                    openFileDialog1.FileName);
                    if (childForm.Filename == null) childForm.Dispose();
                    else childForm.Show();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild is FormCoinView)
            {
                ((FormCoinView)activeChild).SaveFile();
            }
            else if (activeChild is FormBillView)
            {
                ((FormBillView)activeChild).SaveFile();
            }
        }
    }
}
