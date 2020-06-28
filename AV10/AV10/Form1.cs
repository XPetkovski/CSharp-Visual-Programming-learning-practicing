using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV10
{
    public partial class Form1 : Form
    {
        private string FileName;
        private int TimerCall;
        private bool isPaused;
        private BallDoc ballDoc { get; set; }
        public Form1()
        {
            FileName = null;
            TimerCall = 0;
            ballDoc = new BallDoc(this.Width);
            timer1 = new Timer();
            ballDoc.Width = this.Width;
            timer1.Start();
            isPaused = false;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isPaused==false)
            {
                if (TimerCall % 10 == 0)
                {
                    Random r = new Random();
                    var randomY = r.Next(2 * Ball.Radius, this.Height - (2 * Ball.Radius));
                    Ball b = new Ball(new Point(-Ball.Radius, randomY));
                    ballDoc.AddBall(b);
                }
                ballDoc.move();
                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ballDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballDoc.CheckHit(e.X, e.Y);
            Invalidate(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ballDoc.Width = this.Width;
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            Hits.Text = string.Format("Hits: {0}", ballDoc.Hits);
            Misses.Text = string.Format("Hits: {0}", ballDoc.Missess);
            //Invalidate(true);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballDoc = new BallDoc(this.Width);
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Ball flying docs | (*.bfd)";
                saveFileDialog.Title = "Save your flying doc";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
                try
                {
                    using (FileStream stream = new FileStream(FileName, FileMode.OpenOrCreate))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream,((BallDoc)ballDoc));
                        FileName = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving your file");
                }
            }
        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Ball flying docs | (*.bfd)";
                openFileDialog.Title = "Open your flying doc";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = openFileDialog.FileName;
                }
                try
                {
                    using (FileStream stream = new FileStream(FileName, FileMode.Open))
                    {
                        var formatter = new BinaryFormatter();
                        ballDoc = (BallDoc)formatter.Deserialize(stream);
                        //FileName = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while opening your file");
                }
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isPaused == false)
            {
                pauseToolStripMenuItem.Text = "Continue";
                isPaused = true;
            }
            else
            {
                pauseToolStripMenuItem.Text = "Pause";
                isPaused = false;
            }
        }
    }
}
