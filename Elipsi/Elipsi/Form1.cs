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

namespace Elipsi
{
    public partial class Form1 : Form
    {
        private CircleDoc circleDoc;
        private Point prevPoint;
        private Point currentPoint;
        private string FileName;
        private int x, y;
        private int width, height;

        private void timer1_Tick(object sender, EventArgs e)
        {
            circleDoc.ChangeColor();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(prevPoint.IsEmpty)
            {
                prevPoint = e.Location;
            }
            else
            {
                circleDoc.AddCircle(new Point(x, y), width, height);
                prevPoint = Point.Empty;
                currentPoint = Point.Empty;
            }
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            circleDoc.Draw(e.Graphics);
            if(!prevPoint.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 1);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawEllipse(linePen, x, y, width, height);
                linePen.Dispose();
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            newDoc();
            timer1.Start();
        }

        private void newDoc()
        {
            circleDoc = new CircleDoc();
            prevPoint = Point.Empty;
            currentPoint = Point.Empty;
            FileName = "Untitled";
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newDoc();
            Invalidate(true);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDoc();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Elipses: {0}", circleDoc.Circles.Count);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = prevPoint.X;
            y = prevPoint.Y;
            if (x > currentPoint.X)
            {
                x = currentPoint.X;
            }
            if (y > currentPoint.Y)
            {
                y = currentPoint.Y;
            }
            width = Math.Abs(prevPoint.X - currentPoint.X);
            height = Math.Abs(prevPoint.Y - currentPoint.Y);
            Invalidate();
        }

        public void SaveFile()
        {
            if(FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circles doc file (*.cir) | *.cir";
                saveFileDialog.Title = "Save circle file";
                saveFileDialog.FileName = FileName;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }

            if(FileName != null)
            {
                using(FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, circleDoc);
                }
            }
        }

        public void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.cir) | *.cir";
            openFileDialog.Title = "Open circle file";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using(FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        circleDoc = (CircleDoc)formatter.Deserialize(fileStream);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }
    }
}
