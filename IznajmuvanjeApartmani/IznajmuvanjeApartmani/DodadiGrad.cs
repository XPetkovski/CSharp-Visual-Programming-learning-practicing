using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IznajmuvanjeApartmani
{
    public partial class DodadiGrad : Form
    {
        public Grad grad { get; set; }
        public DodadiGrad()
        {
            InitializeComponent();
            grad = new Grad();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внесете име на град!");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (tbPostal.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внесете поштенски број!");
            }
            else
            {
                if (tbPostal.Text.Length > 0 && tbPostal.Text.Length != 4)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPostal, "Внесете 4 бројки за поштенски број!");
                }
                else
                {
                    errorProvider1.SetError(tbPostal, null);
                }
            }      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Form1 f = Parent as Form1;
            //grad = new Grad();
            //grad.cityName = tbIme.Text;
            //grad.postalCode = tbPostal.Text;
            //DialogResult = System.Windows.Forms.DialogResult.OK; 

            if (tbIme != null && !tbIme.Equals("") && tbPostal != null && !tbPostal.Equals(""))
            {
                grad.cityName = tbIme.Text;
                grad.postalCode = tbPostal.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
