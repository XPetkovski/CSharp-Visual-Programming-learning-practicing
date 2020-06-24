using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV6
{
    public partial class Нов_Аеродром : Form
    {
        public Aerodrom aerodrom { get; set; }

        public Нов_Аеродром()
        {
            InitializeComponent();
        }

        private void btnAddAerodrom_Click(object sender, EventArgs e)
        {
            aerodrom = new Aerodrom(txtGrad.Text, txtIme.Text, txtKratenka.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if(txtGrad.Text.Length==0)
            {
                errorProvider1.SetError(txtGrad, "Внесете град!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGrad, null);
                e.Cancel = false;
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(txtIme.Text.Length==0)
            {
                errorProvider1.SetError(txtIme, "Внесете име на аеродромот!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
                e.Cancel = false;
            }
        }

        private void txtKratenka_Validating(object sender, CancelEventArgs e)
        {
            if(txtKratenka.Text.Length != 3)
            {
                errorProvider1.SetError(txtKratenka, "Внесете точно 3 големи букви!");
                e.Cancel = true;
            }
            else
            {
                for(int i=0;i<3;i++)
                {
                    
                    if(!Char.IsLetter(txtKratenka.Text[i]) || !Char.IsUpper(txtKratenka.Text[i]))
                    errorProvider1.SetError(txtKratenka, "Внесете точно 3 големи букви!");
                    e.Cancel = true;
                    
                }
                return;
            }
                errorProvider1.SetError(txtKratenka, null);
                e.Cancel = false;
        }
    }
}
