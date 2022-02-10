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
    public partial class DodadiStudent : Form
    {
        public Student student { get; set; }
        public DodadiStudent()
        {
            InitializeComponent();
        }

        private void btnDodadiStudent_Click(object sender, EventArgs e)
        {
            //if(tbIme != null && !tbIme.Equals("") && tbIndex != null && !tbIndex.Equals(""))
            //{
                Form1 f = Parent as Form1;
                student = new Student();
                student.Ime = tbIme.Text;
                student.Index = tbIndex.Text;
                DialogResult = DialogResult.OK;
            //}
            //else
            //{
                //DialogResult = DialogResult.Cancel;
            //}
        }

        private void btnCancelStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                error.SetError(tbIme, "Внесете име и презиме!");
            }
            else
            {
                error.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void tbIndex_Validating(object sender, CancelEventArgs e)
        {
            if (tbIndex.Text.Trim().Length != 6 || tbIndex.Text.Trim().Length > 6)
            {
                e.Cancel = true;
                error.SetError(tbIndex, "Внесете точно 6 бројки за индекс!");
            }
            else
            {
                error.SetError(tbIme, null);
                e.Cancel = false;
            }
        }
    }
}
