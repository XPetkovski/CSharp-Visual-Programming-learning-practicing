using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class NewBus : Form
    {
        public Buss bus { get; set; }
        public NewBus()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bus = new Buss(tbRegistration.Text.Trim(), tbName.Text.Trim(), cbLocal.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Trim().Length==0)
            {
                errorProvider1.SetError(tbName, "Enter destination please!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbRegistration_Validating(object sender, CancelEventArgs e)
        {
            if (tbRegistration.Text.Trim().Length != 4)
            {
                errorProvider1.SetError(tbRegistration, "Registration should have exactly 4 digits");
                e.Cancel = true;
            }
            else
            {
                string sh = tbRegistration.Text.Trim();
                foreach (char c in sh)
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider1.SetError(tbRegistration, "Registration should have exactly 4 digits");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbRegistration, null);
                e.Cancel = false;
            }
        }
    }
}
