
#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
#endregion
namespace Ranjeet_MindBlowing_memory_game
{
    public partial class memoryGame : Form
    {
        public memoryGame()
        {
            InitializeComponent();
        }
        int choice;

        int[] picked = new int[3];
        int[] behind = new int[17];
        int guesses, remaining;
        SoundPlayer matchSound = new SoundPlayer();
        SoundPlayer noMatchSound = new SoundPlayer();
        PictureBox[] boxes = new PictureBox[17];
        PictureBox[] choices = new PictureBox[9];
        Random myRandom = new Random();
        private void picHidden_Click(object sender, EventArgs e)
        {
            PictureBox pictureClicked;
            int index;
            DateTime start;
            TimeSpan delay;
            pictureClicked = (PictureBox)sender;
            index = Convert.ToInt32(pictureClicked.Name.Substring(9, 2));

            if ((choice == 2 && index == picked[1]) || behind[index] == -1 || btnNew.Enabled)
            {
                return;
            }

            boxes[index].Image = choices[behind[index]].Image;
            boxes[index].Refresh();
            if (choice == 1)
            {
                picked[1] = index;
                choice = 2;
                return;
            }
            guesses++;
            lblGuesses.Text = Convert.ToString(guesses);
            picked[2] = index;
            if (behind[picked[1]] == behind[picked[2]])
            {

                matchSound.Play();
                behind[picked[1]] = -1;
                behind[picked[2]] = -1;
                remaining--;
            }
            else
            {

                noMatchSound.Play();
                // delay one second
                start = DateTime.Now;
                do
                {
                    delay = DateTime.Now - start;
                }
                while (delay.Seconds <= 1.0);
                boxes[picked[1]].Image = picBack.Image;
                boxes[picked[2]].Image = picBack.Image;
            }
            choice = 1;
            if (remaining == 0)
            {
                btnExit.PerformClick();
                btnNew.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "E&xit")
            {
                this.Close();
            }
            else
            {
                btnExit.Text = "E&xit";
                btnNew.Enabled = true;
            }
        }



        private void lblGuesses_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void Bitthdayr_Load(object sender, EventArgs e)
        {
            int i;
            boxes[1] = picHidden01;
            boxes[2] = picHidden02;
            boxes[3] = picHidden03;
            boxes[4] = picHidden04;
            boxes[5] = picHidden05;
            boxes[6] = picHidden06;
            boxes[7] = picHidden07;
            boxes[8] = picHidden08;
            boxes[9] = picHidden09;
            boxes[10] = picHidden10;
            boxes[11] = picHidden11;
            boxes[12] = picHidden12;
            boxes[13] = picHidden13;
            boxes[14] = picHidden14;
            boxes[15] = picHidden15;
            boxes[16] = picHidden16;
            choices[1] = picChoice1;
            choices[2] = picChoice2;
            choices[3] = picChoice3;
            choices[4] = picChoice4;
            choices[5] = picChoice5;
            choices[6] = picChoice6;
            choices[7] = picChoice7;
            choices[8] = picChoice8;


            for (i = 1; i < 17; i++)
            {
                boxes[i].Click += new EventHandler(picHidden_Click);
            }
            noMatchSound.SoundLocation = Application.StartupPath + "\\uhoh.wav";
            matchSound.SoundLocation = Application.StartupPath + "\\tada.wav";
            btnNew.PerformClick();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int i;
            guesses = 0; remaining = 8;
            lblGuesses.Text = "0";

            Shuffle(16, behind);
            for (i = 1; i < 17; i++)
            {

                boxes[i].Image = picBack.Image;
                if (behind[i] > 8)
                {
                    behind[i] -= 8;
                }
            }
            choice = 1;
            btnNew.Enabled = false;
            btnExit.Text = "&Stop";
        }

        private void Shuffle(int numberOfItems, int[] numberList)
        {

            int tempValue, loopCounter, itemPicked, remaining;

            for (loopCounter = 1; loopCounter <= numberOfItems; loopCounter++)
            {
                numberList[loopCounter] = loopCounter;
            }


            for (remaining = numberOfItems; remaining >= 2; remaining--)
            {

                itemPicked = myRandom.Next(remaining) + 1;

                tempValue = numberList[remaining];
                numberList[remaining] = numberList[itemPicked];
                numberList[itemPicked] = tempValue;
            }
        }
        }
    }