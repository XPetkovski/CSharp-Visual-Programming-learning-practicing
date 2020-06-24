using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje5._5
{
    public partial class ControllerForm : Form, IUpdatableView
    {
        Coins coinsDoc;
        List<IUpdatableView> views = new List<IUpdatableView>();
        public ControllerForm()
        {
            InitializeComponent();
            coinsDoc = new Coins(this);
        }
        public void UpdateView()
        {
            tbNumCoins.Text = coinsDoc.NumCoins.ToString();
            Invalidate(true);
            foreach(IUpdatableView uv in views)
            {
                if (uv!=null)
                {
                    uv.UpdateView();
                }
            }
        }
        private void ControllerForm_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void PileView_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(coinsDoc, this);
            views.Add(newForm);
            newForm.Show();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            coinsDoc.addOne();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            coinsDoc.removeOne();
        }

        public void RemoveView(Form1 closingForm)
        {
            views.Remove(closingForm);
        }
    }
}
