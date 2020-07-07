using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosuvackaKosnicka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            NewProduct novprodukt = new NewProduct();
            DialogResult dialogResult = novprodukt.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbProducts.Items.Add(novprodukt.Produkt);
            }
        }

        private void btnEmptyPL_Click(object sender, EventArgs e)
        {
            //int index = lbProducts.SelectedIndex;
           if(MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?", 
               "Message", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                lbProducts.Items.Clear();
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            lbCart.Items.Add(lbProducts.SelectedItem);
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            lbCart.Items.RemoveAt(lbCart.SelectedIndex);
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката со продукти?",
               "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbCart.Items.Clear();
            }
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
        }
    }
}
