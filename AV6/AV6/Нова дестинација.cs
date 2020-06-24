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
    public partial class Нова_дестинација : Form
    {
        private int value1;
        private int value2;

        public Нова_дестинација myDestinacija { get; set; }
        public Нова_дестинација()
        {
            InitializeComponent();
        }

        public Нова_дестинација(string text, int value1, int value2)
        {
            Text = text;
            this.value1 = value1;
            this.value2 = value2;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            myDestinacija = new Нова_дестинација(txtIme.Text, (int)numDolzina.Value, (int)numCena.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
