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

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        private CircleDoc circleDoc;
        Color color;
        Timer timer;
        bool isStarted;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            circleDoc = new CircleDoc();
            color = Color.Red;
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer1_Tick);
            isStarted = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circleDoc.Pulse();
            Invalidate(true);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            circleDoc.AddCircle(e.Location, color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            circleDoc.Draw(e.Graphics);
        }

        private void STARTSTOP_Click(object sender, EventArgs e)
        {
            isStarted = false;
            if(isStarted)
            {
                STARTSTOP.Text = "START";
                timer.Start();
                isStarted = true;
            }
            else
            {
                STARTSTOP.Text = "STOP";
                timer.Stop();
                isStarted = false;
            }
        }

        private void cOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
            }
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circles doc file (*.plc)|*.plc";
                saveFileDialog.Title = "Save circles doc";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, circleDoc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.plc)|*.plc";
            openFileDialog.Title = "Open circles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        circleDoc = (CircleDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            circleDoc = new CircleDoc();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc = new CircleDoc();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total: {0}", circleDoc.circles.Count);
        }
    }
}
