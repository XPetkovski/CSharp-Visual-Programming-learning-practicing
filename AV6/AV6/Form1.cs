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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) //dodaj aerodrom Нов_Аеродром
        {
            Нов_Аеродром forma = new Нов_Аеродром();
            if(forma.ShowDialog()==DialogResult.OK)
            {
                lbAerodromi.Items.Add(forma.aerodrom);
            }
        }

        private void loadDestinacii()
        {
            lbDestinacii.Items.Clear(); //praznenje
            if(lbAerodromi.SelectedIndex != 1)
            {
                Aerodrom selektiranAerodrom = ((Aerodrom)lbAerodromi.SelectedItem).destinacii;
                Destinacija najskapa = null;
                float prosek = 0;
                bool daliPrvpat = true;
                foreach (Destinacija d in selektiranAerodrom.destinacii)
                    {
                    if(daliPrvpat)
                    {
                        najskapa = d;
                        daliPrvpat = false;
                    }
                    if(d.cena > najskapa.cena)
                    {
                        najskapa = d;
                    }
                        lbDestinacii.Items.Add(d);
                    prosek += d.oddalecenost;
                    }
                if(prosek!=0)
                {
                    prosek = prosek / selektiranAerodrom.destinacii.Count;
                    prosecnaDolzina.Text = string.Format("{0}", prosek);
                }
                if(najskapa != null)
                {
                    najskapaDestinacija.Text = najskapa.ToString();
                }
            }

        }
        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            //Нова_дестинација forma = new Нова_дестинација();
            if(lbAerodromi.SelectedIndex!=-1)
            {
                Нова_дестинација forma = new Нова_дестинација();
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ((Aerodrom)lbAerodromi.SelectedItem).destinacii.Add(forma.myDestinacija);
                    loadDestinacii();
                }
            }
            
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете аеродромот?", "Избриши?", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                if(lbAerodromi.SelectedIndex!=-1)
                {
                    lbAerodromi.Items.Remove(lbAerodromi.SelectedItem);
                    loadDestinacii();
                }
            }
            
        }

        private void lbAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestinacii();
        }
    }
}
