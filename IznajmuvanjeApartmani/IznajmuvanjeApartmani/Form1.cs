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

        public void btnAddCity_Click(object sender, EventArgs e)
        {
            //DodadiGrad grad = new DodadiGrad();
            DodadiGrad grad = new DodadiGrad();
            DialogResult dialogResult = grad.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbCity.Items.Add(grad.grad);
            }
            UpdateApartmani();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете град?",
               "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbCity.Items.RemoveAt(lbCity.SelectedIndex);
                tbNajevtin.Text = "";
                lbApartmani.Items.Clear();
            }

        }

        private void btnAddApartman_Click(object sender, EventArgs e)
        {
            //DodadiGrad grad = new DodadiGrad();
            DodadiApartman apartman = new DodadiApartman();
            DialogResult dialogResult = apartman.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                lbApartmani.Items.Add(apartman.apartman);
            }
            else
            {
                dialogResult = DialogResult.Cancel;
            }
        }

        private void UpdateApartmani()
        {
            if(lbCity.SelectedIndex != -1)
            {
                lbApartmani.Items.Clear();
                tbNajevtin.Text = "";
                int najvetin = 1000000;
                Apartman najevtinApartman = null;
                Grad g = (Grad)lbCity.SelectedItem;
                foreach(Apartman a in g.apartmani)
                {
                    lbApartmani.Items.Add(a);
                    if(a.Cena < najvetin)
                    {
                        najvetin = a.Cena;
                        najevtinApartman = a;
                    }
                }
                if(najevtinApartman != null)
                {
                    tbNajevtin.Text = najevtinApartman.ToString();
                }
            }
        }

        private void lbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateApartmani();
        }
    }
}
