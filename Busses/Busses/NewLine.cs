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
    public partial class NewLine : Form
    {
        public Line Line { get; set; }
        
        public NewLine()
        {
            InitializeComponent();
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestination.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbDestination, "Enter destination please!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Line = new Line(tbDestination.Text.Trim(), (int)nudHour.Value, (int)nudMinute.Value, (int)nudPrice.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
