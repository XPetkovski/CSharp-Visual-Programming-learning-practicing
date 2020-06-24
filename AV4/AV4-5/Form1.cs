using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbString.Text != null && !tbString.Text.Equals(""))
            {
                if(lbSimple.Items.Count < 5 && !lbSimple.Items.Contains(tbString.Text))
                {
                    lbSimple.Items.Add(tbString.Text);
                }
                if (lbChecked.Items.Count < 5 && !lbChecked.Items.Contains(tbString.Text))
                {
                    lbChecked.Items.Add(tbString.Text);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbSimple.SelectedIndex!=-1)
            {
                lbSimple.Items.RemoveAt(lbSimple.SelectedIndex);
            }
        }

        private void bntDeleteChecked_Click(object sender, EventArgs e)
        {
            if(lbChecked.SelectedIndex!=-1)
            {
                lbChecked.Items.RemoveAt(lbChecked.SelectedIndex);
            }
        }
    }
}
