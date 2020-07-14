using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportskiRezultati
{
    public partial class AddNewGame : Form
    {
        public AddNewGame()
        {
            InitializeComponent();
        }

        private void btnAddHomeGoalscorer_Click(object sender, EventArgs e)
        {
            AddGoalscorer homegoalscorer = new AddGoalscorer();
            DialogResult dialogResult = homegoalscorer.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                lbHomeGoalScorer.Items.Add(homegoalscorer);
            }
        }

        private void btnAddAwayGoalscorer_Click(object sender, EventArgs e)
        {
            AddGoalscorer awaygoalscorer = new AddGoalscorer();
            DialogResult dialogResult = awaygoalscorer.ShowDialog();
        }

        private void btnAddGameToList_Click(object sender, EventArgs e)
        {
            
        }
    }
}
