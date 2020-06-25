using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje6
{
    public partial class FormBillView : Form
    {
        private Bills billsDoc;
        public string Filename { get; private set; }
        public bool isChanged { get; private set; }
        public FormBillView()
        {
            InitializeComponent();
            billsDoc = new Bills();
            isChanged = true;
        }
        public FormBillView(Form1 parent, string filename = null) : this()
        {
            this.MdiParent = parent;
            if(filename != null)
            {
                openFile(filename);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billsDoc = new Bills();
            isChanged = true;
            Invalidate(true);
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //add bill
        {
            billsDoc.addOne();
            isChanged = true;
            Invalidate(true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // remove bill
        {
            billsDoc.removeOne();
            isChanged = true;
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        public void SaveFile()
        {
            if (Filename == null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Bill file (*.bil)|*.bil";
                saveFileDialog1.Title = "Save a bill file";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Filename = saveFileDialog1.FileName;
                }
            }
            if (Filename != null)
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(Filename, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, billsDoc);
                strm.Close();
                isChanged = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bill file (*.bil)|*.bil";
            openFileDialog1.Title = "Open a bill file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
            Invalidate(true);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String oldname = Filename;
            Filename = null;
            saveAsToolStripMenuItem_Click(sender, e);
            if (Filename == null)
            {
                Filename = oldname;
            }
        }

        public void openFile(string fileName)
        {
            try
            {
                Filename = fileName;
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.None);
                billsDoc = (Bills)fmt.Deserialize(strm);
                strm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Could not read file \"" + fileName + "\" from disk. Original error: " + e.Message);
                Filename = null;
            }
            if (Filename != null)
            {
                isChanged = false;
            }
        }

        private void FormBillView_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveToolStripButton.Enabled = isChanged;
            saveAsToolStripMenuItem.Enabled = isChanged;
        }

        private void BillsNumber_Paint(object sender, PaintEventArgs e)
        {
            BillsNumber.Text = "#bills: " + billsDoc.numBills.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Bills";
            if (Filename != null)
            {
                this.Text += " - " + System.IO.Path.GetFileName(Filename);
                SolidBrush br = new SolidBrush(Color.LightGreen);
                Pen pn = new Pen(Color.Black, 1);
                Graphics canvas = this.CreateGraphics();
                canvas.Clear(Color.White);
                for (int nCount = 0; nCount < billsDoc.numBills; nCount++)
                {
                    canvas.FillRectangle(br, 40 + nCount * 20, 60 + nCount * 5, 100,40);
                    canvas.DrawRectangle(pn, 40 + nCount * 20, 60 + nCount * 5, 100, 40);
                    canvas.DrawEllipse(pn, 40 + nCount * 20 + 40, 60 + 5 +   nCount * 5, 20, 30);
                }
                pn.Dispose();
                br.Dispose();
            }
        }
    }
}
