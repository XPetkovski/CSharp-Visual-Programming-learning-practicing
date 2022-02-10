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

namespace BlackHoles
{
    [Serializable]
    public partial class Form1 : Form
    {
        //private CircleDoc circleDoc;
        public Form1()
        {
            InitializeComponent();
        }
        public string FileName;
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
            openFileDialog.Filter = "Circles/Cubes doc file (*.ccf)|*.ccf";
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

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFile();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.circleDoc.MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                this.circleDoc.MoveDown();
            }
            if (e.KeyCode == Keys.Left)
            {
                this.circleDoc.MoveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                this.circleDoc.MoveRight();
            }
            this.circleDoc.deleteCollided();
            base.Invalidate();
        }

        public CircleDoc circleDoc { get; set; }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.circleDoc.drawAll(e.Graphics);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.circleDoc.DoubleClick(e.Location);
            base.Invalidate();
        }
    }
}
