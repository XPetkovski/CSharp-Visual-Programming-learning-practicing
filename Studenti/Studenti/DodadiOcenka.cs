using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    public partial class DodadiOcenka : Form
    {
        public Ocena ocena { get; set; }
        public DodadiOcenka()
        {
            InitializeComponent();
        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbVnesiOcena_Click(object sender, EventArgs e)
        {
            Form1 f = Parent as Form1;
            ocena = new Ocena();
            ocena.ImePredmet = tbPredmet.Text;
            ocena.BrojOcena = numOcena.Text;
            DialogResult = DialogResult.OK;
        }

        private void tbPredmet_Validating(object sender, CancelEventArgs e)
        {
            if (tbPredmet.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                error2.SetError(tbPredmet, "Внесете предмет!");
            }
            else
            {
                error2.SetError(tbPredmet, null);
                e.Cancel = false;
            }
        }
    }
}
