using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV7
{
    public partial class Form1 : Form
    {
        private HangmanWord hangmanWord;
        private IWordSelector wordSelector;
        private static readonly int MAX_TIME = 60 * 2;
            private int timeElapsed;

       
        public Form1()
        {
            InitializeComponent();
            wordSelector = new WordSelector();
            
            newGame();
        }

        private void newGame()
        {
            hangmanWord = new HangmanWord(wordSelector.pick());
            timeElapsed = 0;
            timer1.Start();
            pbTime.Maximum = MAX_TIME;
            pbTime.Value = MAX_TIME;
            pbWrong.Maximum = HangmanWord.MAX_ATTEMPTS;
            pbWrong.Value = 0; //hangmanWord.WrongAttempts;
            tbLetter.Enabled = true;
            btnGuess.Enabled = true;
            updateMasks();
        }

        private void updateMasks()
        {
            lbWord.Text = hangmanWord.wordMask();
            tbDiscovered.Text = hangmanWord.guessedLetterMask();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            
        }

        private void EnterLetter()
        {
            if (tbLetter.Text == null || tbLetter.Text.Length != -1)
            {
                return;
            }
            char c = char.ToLower(tbLetter.Text[0]);
            if (hangmanWord.guessLetter(c))
            {
                updateMasks();
                pbWrong.Value = hangmanWord.WrongAttempts;
                checkGameState();
            }
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            EnterLetter();
        }

        private void checkGameState()
        {
            bool finish = false;
            string caption = null;
            if(hangmanWord.IsGuessed)
            {
                finish = true;
                caption = string.Format("POBEDA. Go pogodivte zborot za {0:00}:{1:00}", timeElapsed / 60, timeElapsed % 60);

            }
            else if(hangmanWord.GameOver)
            {
                finish = true;
                caption = string.Format("PORAZ. Ne go pogodivte zborot za {0:00}:{1:00}", timeElapsed / 60, timeElapsed % 60);
            }
            else
            {
                return;
            }
            if(finish==true)
            {
                timer1.Stop();
                tbLetter.Enabled = false;
                btnGuess.Enabled = false;
                updateMasks();
                startNewGame(caption);
            }
            //throw new NotImplementedException();
        }

        private void startNewGame(string caption)
        {
            DialogResult result = MessageBox.Show(caption, "NEW GAME?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                newGame();
            }
            else
            {
                this.Close();
            }
            //throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            pbTime.Value = MAX_TIME - timeElapsed;
            if(timeElapsed == MAX_TIME)
            {
                hangmanWord.endGame();
                tbLetter.Enabled = false;
                btnGuess.Enabled = false;
                updateMasks();
                timer1.Stop();
            }
            updateRemainingTime();
        }

        private void updateRemainingTime()
        {
            int value = pbTime.Value;
            lbTime.Text = String.Format("{0:00}:{1:00}", value / 60, value % 60);
            //throw new NotImplementedException();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}
