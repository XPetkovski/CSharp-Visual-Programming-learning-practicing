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
    public partial class DodadiApartman : Form
    {
        public Apartman apartman { get; set; }

        public DodadiApartman()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Form1 f = Parent as Form1;
            apartman = new Apartman(tbAdresa.Text, (int)nudCena.Value);
            DialogResult = DialogResult.OK;
            //grad.cityName = tbIme.Text;
            //grad.postalCode = tbPostal.Text;
            //DialogResult = System.Windows.Forms.DialogResult.OK; 

            /*if (tbAdresa != null && !tbAdresa.Equals("") && nudCena != null && !nudCena.Equals(""))
            {
                apartman.Adresa = tbAdresa.Text;
                apartman.Cena = nudCena.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            } */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
