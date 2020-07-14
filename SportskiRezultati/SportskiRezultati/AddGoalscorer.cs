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
    public partial class AddGoalscorer : Form
    {
        //public Football football = new Football();
        public Details<int, string> detaliG = new Details<int, string>();
        public Game<Football> fGame = new Game<Football>();
        public AddGoalscorer()
        {
            InitializeComponent();
            fGame = new Game<Football>();
            detaliG = new Details<int, string>();
        }

        private void tbPlayer_Validating(object sender, CancelEventArgs e)
        {
            if(tbPlayer.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPlayer, "Внесете име на играч!");
            }
            else
            {
                errorProvider1.SetError(tbPlayer, null);
            }
        }

        private void tbGoal_Validating(object sender, CancelEventArgs e)
        {
            if (tbGoal.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbGoal, "Внесете поени/голови колку постигнал играчот!");
            }
            else
            {
                errorProvider1.SetError(tbGoal, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelAddGoalScorer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddGoalscorerToList_Click(object sender, EventArgs e)
        {
            if(tbPlayer.Text.Trim().Length != 0)
            {
                Football detailsVisitor = new Football();
                for (int j = 0; j < detaliG.value; j++)
                {
                    Details<int, string> detali = detaliG[j];
                    Details<string, string> dt = new Details<string, string>();
                    dt.key = detali.key + " min";
                    dt.value = detali.value;
                    detailsVisitor.gameDetails.Add(dt);
                }
                fGame.detailsVisitor = detailsVisitor;
            }
        }
    }
}
