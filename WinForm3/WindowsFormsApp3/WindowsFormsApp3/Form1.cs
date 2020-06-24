using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class KOPCE : Form
    {

        public KOPCE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbVozrast_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbVozrast_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int vozrast;
            if (!int.TryParse(tbVozrast.Text, out vozrast) || vozrast < 1)
            {
                errorMsg = "Невалидна возраст!";
                e.Cancel = true;
                tbVozrast.Select(0, tbVozrast.Text.Length);
                errorProviderVozrast.SetError(tbVozrast, errorMsg);
            }
            else
                errorProviderVozrast.SetError(tbVozrast, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            if(emailAddress.Length == 0)
            {
                errorMessage = "E-mail address is required.";
                return false;
            }
            int atpos;
            if((atpos=emailAddress.IndexOf("@"))>-1)
            {
                if(emailAddress.IndexOf(".", atpos)>atpos && emailAddress.IndexOf("@", atpos+1)<=atpos)
                {
                    errorMessage = ".";
                    return true;
                }
            }
            errorMessage = "E-mail адресата мора да биде во валиден формат \n" + "На пример: 'someone@example.com' ";
            return false;
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(tbEmail.Text, out errorMsg))
            {
                e.Cancel = true;
                errorProviderEmail.SetError(tbEmail, errorMsg);
            }
            else
                errorProviderEmail.SetError(tbEmail, "");
        }

        private void tbKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(c!= '\b' && !((c>='a' && c<='f') || (c<='F' && c>= 'A') || c>= '0' && c<='9'))
            {
                e.Handled = true;
            }
            if(c >= 'a' && c<='f')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting...");
            this.Close();
        }

        private void ги_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = ги.Checked;
        }

        private void условите_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUslovi formUslovi = new FormUslovi();
            formUslovi.ShowDialog();
        }
    }
}
