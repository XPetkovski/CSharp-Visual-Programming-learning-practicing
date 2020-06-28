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

namespace AV9
{
    public partial class Form1 : Form
    {
        private Scene scena { get; set; }
        public Form1()
        {
            scena = new Scene();
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.Click(e.Location);
            Invalidate(true);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scena.Move(e.Location);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.Draw(e.Graphics);
            //Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save our polygon app: ";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, scena);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a polygon app: ";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    this.scena = (Scene)formatter.Deserialize(stream);
                }
            }
        }
    }
}
