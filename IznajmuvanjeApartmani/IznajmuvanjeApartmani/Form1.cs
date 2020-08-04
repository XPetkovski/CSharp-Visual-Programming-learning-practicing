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
    public partial class Form1 : Form
    {
        //public Grad GRad { get; set; }
        //public DodadiGrad grad = new DodadiGrad();
        //public DodadiApartman apartman = new DodadiApartman();
        public Form1()
        {
            InitializeComponent();
            //GRad = new Grad();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            //DodadiGrad grad = new DodadiGrad();
            DodadiGrad grad = new DodadiGrad();
            DialogResult dialogResult = grad.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbCity.Items.Add(grad);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете град?",
               "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbCity.Items.RemoveAt(lbCity.SelectedIndex);
            }

        }

        private void btnAddApartman_Click(object sender, EventArgs e)
        {
            //DodadiGrad grad = new DodadiGrad();
            DodadiApartman apartman = new DodadiApartman();
            DialogResult dialogResult = apartman.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                lbApartmani.Items.Add(apartman);
            }
            else
            {
                dialogResult = DialogResult.Cancel;
            }
        }
    }
}
