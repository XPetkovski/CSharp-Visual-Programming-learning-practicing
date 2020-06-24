using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void textBox5_TextChanged(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbVozrast_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsg;
            int vozrast;
            if (!int.TryParse(tbVozrast.Text, out vozrast) || vozrast < 1)
            {
                ErrorMsg = "Невалидна возраст!";
                e.Cancel = true;
                tbVozrast.Select(0, tbVozrast.Text.Length);
                errorProvider1.SetError(tbVozrast, ErrorMsg);
            }
            else errorProvider1.SetError(tbVozrast, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required!";
                return false;
            }
            int atpos;
            if ((atpos = emailAddress.IndexOf(_AppDomain"@")) > -1)
            {
                if (emailAddress.IndexOf(".", atpos) > atpos && emailAddress.IndexOf("@", atpos + 1) <= atpos)
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "e-mail адресата мора да биде во валиден формат \n" +
                            "На пример: 'someone@example.com' ";
            return false;
        }

        private void tbEmail_Validating_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsg;
            
            if (!ValidEmailAddress(tbEmail.Text, out ErrorMsg))
            {
                e.Cancel = true;
                errorProviderEmail.SetError(tbEmail, ErrorMsg);
            }
            else errorProviderEmail.SetError(tbEmail, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
