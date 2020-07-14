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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Buss bus = new Buss("5463", "JSP 5", true);
            bus.AddDestination(new Line("Aerodrom", 12, 5, 35));
            lbBus.Items.Add(bus);
            loadLines();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            NewBus novbus = new NewBus();
            DialogResult dialogResult = novbus.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbBus.Items.Add(novbus.bus);
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            NewLine novalinija = new NewLine();
            DialogResult dialogResult = novalinija.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbLines.Items.Add(novalinija.Line);
            }
        }

        void loadLines()
        {
            lbLines.Items.Clear();
            tbAverage.Clear();
            tbExpensive.Clear();
            Buss bus = lbBus.SelectedItem as Buss;
            if(bus != null && bus.Lines.Count > 0)
            {
                Line maxPrice = bus.Lines[0];
                float totalPrice = 0;
                foreach(Line line in bus.Lines)
                {
                    lbLines.Items.Add(line);
                    if(line.Price > maxPrice.Price)
                    {
                        maxPrice = line;
                    }
                    totalPrice += line.Price;
                }
                tbAverage.Text = string.Format("{0:#.0}", totalPrice / lbLines.Items.Count);
                tbExpensive.Text = maxPrice.ToString();
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you wanna delete this Bus?", "Delete bus", MessageBoxButtons.YesNo) == 
                System.Windows.Forms.DialogResult.Yes)
            {
                lbBus.Items.RemoveAt(lbBus.SelectedIndex);
                loadLines();
            }
        }

        private void lbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteBus.Enabled = lbBus.SelectedIndex != -1;
            btnAddBus.Enabled = lbBus.SelectedIndex != -1;
            loadLines();
        }
    }
}
