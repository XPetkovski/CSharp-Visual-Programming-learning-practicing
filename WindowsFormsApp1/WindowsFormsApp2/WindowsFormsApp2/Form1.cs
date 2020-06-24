using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool Pozdraven { set; get; }
        public Form1()
        {
            InitializeComponent();
            Pozdraven = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("            TI KAZAV NE KLIKAJ MOCKO, SEA KE KRASNAM");
            Application.Exit();
            
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)//a
        {
            if(checkBox3.Checked)
            {
                MessageBox.Show("Installing...");
            }
            
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)//B
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("Installing...");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//C
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Installing...");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){}

        private void button2_Click(object sender, EventArgs e) //HELLO
        {
            MessageBox.Show("HELLO");
            Pozdraven = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pozdraven)
            {
                MessageBox.Show("GOODBYE");
                Application.Exit();
            }
            else MessageBox.Show("   HOW DO YOU SAY GOODBYE, WHEN YOU'VE HARDLY SAID HELLO!");
        }
    }
}
