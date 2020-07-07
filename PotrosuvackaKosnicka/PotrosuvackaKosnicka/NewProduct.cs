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
    public partial class NewProduct : Form
    {
        public Produkt Produkt { get; set; }
        public NewProduct()
        {
            InitializeComponent();
            Produkt = new Produkt();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                ep1.SetError(tbName, "Внесете име!");
            }
            else
            {
                ep1.SetError(tbName, null);
            }
        }

        private void tbCategory_Validating(object sender, CancelEventArgs e)
        {
            if(tbCategory.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                ep1.SetError(tbCategory, "Внесете категорија!");
            }
            else
            {
                ep1.SetError(tbCategory, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrice.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                ep1.SetError(tbPrice, "Внесете цена!");
            }
            else
            {
                ep1.SetError(tbPrice, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbName!=null && !tbName.Equals("") && tbCategory != null && !tbCategory.Equals("") && tbPrice!= null && !tbPrice.Equals(""))
            {
                Produkt.Name = tbName.Text;
                Produkt.Category = tbCategory.Text;
                Produkt.Price = tbPrice.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
