using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV5
{
    public partial class TeamForm : Form
    {
        public Team Team { get; set; }
        public TeamForm()
        {
            InitializeComponent();
            Team = new Team();
        }



        private void TeamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if(tbTeamCountry!=null && !tbTeamCountry.Equals("") && tbTeamName != null && !tbTeamName.Equals(""))
            {
                Team.Country = tbTeamCountry.Text;
                Team.Name = tbTeamName.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

        }
    }
}
