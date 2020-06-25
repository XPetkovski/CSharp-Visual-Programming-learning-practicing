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
    public partial class FormCoinView : Form
    {
        private Coins CoinsDoc;
        public string FileName { get; set; }
        public bool isChanged { get; private set; }

        public FormCoinView()
        {
            InitializeComponent();
            CoinsDoc = new Coins();
        }
        public FormCoinView(Form1 parent, string filename = null) : this()
        {
            this.MdiParent = parent;
            if(filename!=null)
            {
                openFile(filename);
            }    
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoinsDoc = new Coins();
            isChanged = true;
            Invalidate(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) //coin view paint
        {
            SolidBrush br = new SolidBrush(Color.Gold);
            Pen pn = new Pen(Color.Black);
            Graphics canvas = panel1.CreateGraphics();
            canvas.Clear(Color.White);
            for(int nCount = 0; nCount < CoinsDoc.numCoins;nCount++)
            {
                int y = panel1.Size.Height - 50 - 10 * nCount;
                canvas.FillEllipse(br, 40, y, 100, 30);
                canvas.DrawEllipse(pn, 40, y, 100, 30);
                canvas.FillEllipse(br, 40, y - 9, 100, 30);
                canvas.DrawEllipse(pn, 40, y - 9, 100, 30);
            }
            pn.Dispose();
            br.Dispose();
        }

        private void AddCoin(object sender, EventArgs e)//click
        {
            CoinsDoc.addOne();
            isChanged = true;
            Invalidate(true);
        }

        private void RemoveCoin_click(object sender, EventArgs e)
        {
            CoinsDoc.removeOne();
            isChanged = true;
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        public void SaveFile()
        {
            if(FileName==null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Coin file (*.coi)|*.coi";
                saveFileDialog1.Title = "Save a coin file";
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                }
            }
            if(FileName != null)
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, CoinsDoc);
                strm.Close();
                isChanged = false;
            }    
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Coin file (*.coi)|*.coi";
            openFileDialog1.Title = "Open a coin file";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
            Invalidate(true);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String oldname = FileName;
            FileName = null;
            saveAsToolStripMenuItem_Click(sender, e);
            if(FileName==null)
            {
                FileName = oldname;
            }
        }

        public void openFile(string fileName)
        {
            try
            {
                FileName = fileName;
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                CoinsDoc = (Coins)fmt.Deserialize(strm);
                strm.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: Could not read file \"" + fileName + "\" from disk. Original error: " + e.Message);
                FileName = null;
            }
            if(FileName != null)
            {
                isChanged = false;
            }
        }

        private void FormCoinView_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Coins";
            if(FileName!=null)
            {
                this.Text += " - " + System.IO.Path.GetFileName(FileName);
            }
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveToolStripMenuItem.Enabled = isChanged;
            saveAsToolStripMenuItem.Enabled = isChanged;
        }

        private void CoinsNumber_Paint(object sender, PaintEventArgs e)
        {
            CoinsNumber.Text = "#coins: " + CoinsDoc.numCoins.ToString();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
