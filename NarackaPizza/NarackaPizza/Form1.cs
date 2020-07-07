using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarackaPizza
{
    public partial class Form1 : Form
    {
        public int Total { get; set; }
        public Form1()
        {
            
            InitializeComponent();
        }

        public void calculateTotal()
        {
            
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSmall.Checked)
            {
                tbSmall.Text = "200";
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMedium.Checked)
            {
                tbMedium.Text = "300";
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLarge.Checked)
            {
                tbLarge.Text = "500";
            }
        }

        private void cbFeferons_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFeferons.Checked)
            {
                tbFeferons.Text = "40";
            }
        }

        private void cbCheese_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCheese.Checked)
            {
                tbCheese.Text = "30";
            }
        }

        private void cbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if(cbKetchup.Checked)
            {
                tbKetchup.Text = "20";
            }
        }

        private void tbTotalDrink1_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(tbCoke.Text);
            Int32 val2 = Convert.ToInt32(tbPriceCoke.Text);
            Int32 val3 = val1 * val2;
            tbTotalDrink1.Text = val3.ToString();
        }

        private void tbTotalDrink2_Click_1(object sender, EventArgs e)
        {
            //Int32 val1 = Convert.ToInt32(tbQuantityJuice.Text);
            //Int32 val2 = Convert.ToInt32(tbPriceJuice.Text);
            //Int32 val3 = val1 * val2;
            //tbTotalDrink2.Text = val3.ToString();
            //tbTotalDrink2.Enabled = false;
            //Invalidate();

            double f1, g1, j;
            double.TryParse(tbQuantityJuice.Text, out f1);
            double.TryParse(tbPriceJuice.Text, out g1);
            j = f1 * g1;
            tbTotalDrink2.Text = j.ToString();
            Invalidate();
        }

        private void tbTotalDrink3_Click(object sender, EventArgs e)
        {
            double f1, g1, j;
            double.TryParse(tbBeer.Text, out f1);
            double.TryParse(tbPriceBeer.Text, out g1);
            j = f1 * g1;
            tbTotalDrink3.Text = j.ToString();
            Invalidate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void rbFruitPie_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFruitPie.Checked)
            {
                tbFruitPie.Text = "80";
            }
        }

        private void rbIceCream_CheckedChanged(object sender, EventArgs e)
        {
            if(rbIceCream.Checked)
            {
                tbIceCream.Text = "120";
            }
        }

        private void rbCake_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCake.Checked)
            {
                tbCake.Text = "160";
            }
        }
    }
}
