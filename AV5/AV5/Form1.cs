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
    public partial class Form1 : Form
    {
        public List<Ticket> tickets { get; set; }

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            DialogResult result = teamForm.ShowDialog();

            if(result==DialogResult.OK)
            {
                lbTeams.Items.Add(teamForm.Team);
            }
        }

        private void btnAddGame_Click_1(object sender, EventArgs e) //Dodaj vo bilten
        {
            if (lbTeams.SelectedItems.Count != 2)
            {
                MessageBox.Show("Селектирајте точно 2 тима!");
                return;
            }

            if (tbCode.Text == null || tbCode.Text.Equals(""))
            {
                MessageBox.Show("Внесете шифра на натпреварот!");
                return;
            }
            
            if(!CheckSameCodeInBilten(tbCode.Text))
            {
                MessageBox.Show("Веќе постои натпревар со ист код!");
                return;
            }

            Game Game = new Game();
            Game.Home = (Team)lbTeams.SelectedItems[0];
            Game.Away = (Team)lbTeams.SelectedItems[1];
            Game.Code = tbCode.Text;
            Game.Coef[0] = (double)nudCoef1.Value;
            Game.Coef[1] = (double)nudCoefX.Value;
            Game.Coef[2] = (double)nudCoef2.Value;
            lbGames.SelectedItems.Add(Game);
            lbGames.SelectedItems.Clear();
            tbCode.Clear();
        }

        private bool CheckSameCodeInBilten(string code)
        {
            foreach(Game g in lbGames.Items)
            {
                if(g.Code.Equals(code))
                {
                    return false;
                }  
            }
            return true;
        }

        private void BtnAddToTicket(object sender, EventArgs e)
        {
            if(lbGames.SelectedIndex!=-1 && comboBox1.SelectedIndex!=-1)
            {
                //validno
                Ticket ticket = new Ticket();
                Game g = (Game)lbGames.SelectedItem;
                int tip = comboBox1.SelectedIndex; //0,1,2;

                ticket.game = g;
                ticket.tip = tip;

                if(CheckSameCodeInTickets(g.Code))
                {
                    lbTickets.Items.Add(ticket);
                    tickets.Add(ticket);
                    lbGames.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Веќе постои таков натпревар!");
                }
                
            }
            else
            {
                MessageBox.Show("Не може да го уплатите натпреварот!");
            }
        }

        private bool CheckSameCodeInTickets(string code)
        {
            foreach (Ticket t in tickets)
            {
                if (t.Game.Code.Equals(code))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
