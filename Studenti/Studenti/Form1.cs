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
    public partial class Form1 : Form
    {
        public Student student;
        public Ocena ocena;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DodadiStudent forma = new DodadiStudent();
            DialogResult dialogResult = forma.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbStudent.Items.Add(forma.student);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете студент?",
               "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbStudent.Items.RemoveAt(lbStudent.SelectedIndex);
                tbProsecnaOcena.Text = "";
                lbOcena.Items.Clear();
            }
        }

        private void btnAddOcena_Click(object sender, EventArgs e)
        {
            DodadiOcenka forma = new DodadiOcenka();
            DialogResult dialogResult = forma.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbOcena.Items.Add(forma.ocena);
            }
        }

        private void Prosek()
        {
            if(lbStudent.SelectedIndex != -1)
            {
                lbOcena.Items.Clear();
                tbProsecnaOcena.Text = "";
                float prosek = 0;
                //string n = ocena.BrojOcena;
                Student s = (Student)lbStudent.SelectedItem;
                foreach (Student a in s.studenti)
                {
                    lbOcena.Items.Add(a);
                    //prosek = ocena.BrojOcena / (float)n;
                }
                if(prosek != null)
                {
                    tbProsecnaOcena.Text = prosek.ToString();
                }
            }
            
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prosek();
        }

        private void lbOcena_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prosek();
        }
    }
}
