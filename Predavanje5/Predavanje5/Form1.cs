using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje5
{
    public partial class Form1 : Form
    {
        Point mouseDownPoint = Point.Empty;
        bool bDrawingEnabled = false;
        Pen pn;

        public Point clickPosition;
        protected Point scrollPosition;
        Bitmap bmpImg;
        String strPathToLoadedImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Bitmap imgNewPic = null;
                //if(bmpImg!=null)
                //{
                // bmpImg.Dispose();
                // bmpImg = null;
                //}
                try
                {
                    imgNewPic = new Bitmap(openFileDialog1.FileName);
                    //bmpImg = new Bitmap(openFileDialog1.FileName);
                    //textBox1.Text = openFileDialog1.FileName.Remove(0, openFileDialog1.FileName.LastIndexOf('\\') + 1);
                    //lblImgSize.Text = bmpImg.Size.Height.ToString() + "x" + bmpImg.Size.Width.ToString();
                    //SuspendLayout();
                    //pcbox.Image = bmpImg;
                    //PerformLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:Could not read file \"" + openFileDialog1.FileName + "\" from disk. Original error: " + ex.Message);
                    if (imgNewPic != null)
                    {
                        imgNewPic.Dispose();
                        imgNewPic = null;
                    }
                }
                if(imgNewPic!=null)
                {
                    strPathToLoadedImage = openFileDialog1.FileName;
                    panel1.HorizontalScroll.Value = 0;
                    panel1.VerticalScroll.Value = 0;
                    ShowImage(imgNewPic);
                }
                
            }
            
        }

        protected void ShowImage(Bitmap imgLoadedImg)
        {
            SuspendLayout();
            pcbox.Size = panel1.Size;
            if(imgLoadedImg.Size.Height < panel1.Size.Height && imgLoadedImg.Size.Width < panel1.Size.Width)
            {
                pcbox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if(Zoom.CheckState == CheckState.Checked)
            {
                pcbox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                if(Scale.CheckState == CheckState.Checked)
                {
                    pcbox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }
            Bitmap oldImg = bmpImg;
            pcbox.Image = bmpImg = imgLoadedImg;
            if(oldImg!=null && oldImg != bmpImg)
            {
                oldImg.Dispose();
                oldImg = null;
            }

            textBox1.Text = strPathToLoadedImage.Remove(0, strPathToLoadedImage.LastIndexOf('\\') + 1) + " (" + pcbox.Image.Size.Height.ToString()
                + " x " + pcbox.Size.Width.ToString() + ")";
            ResumeLayout();

        }

        private void Zoom_CheckedChanged(object sender, EventArgs e)
        {
            ShowImage(bmpImg);
        }

        private void Scale_CheckedChanged(object sender, EventArgs e)
        {
            panel1.HorizontalScroll.Value = 0;
            panel1.VerticalScroll.Value = 0;
            ShowImage(bmpImg);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            pn = new Pen(Color.BackColor, (float)numericUpDown1.Value);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void lblImgSize_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Zoom_Click(object sender, EventArgs e)
        {

        }

        private void pcbox_MouseDown(object sender, MouseEventArgs e)
        {
            clickPosition = e.Location;
            scrollPosition = panel1.AutoScrollPosition;
            this.Cursor = Cursors.Hand;
            if(bDrawingEnabled)
            {
                mouseDownPoint = e.Location;
            }
        }

        private void pcbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.SuspendLayout();
                scrollPosition += (Size)clickPosition - (Size)e.Location;
                if (scrollPosition.X < 0) scrollPosition.X = 0;
                if (scrollPosition.Y < 0) scrollPosition.Y = 0;
                if(scrollPosition.X > pcbox.Width)
                {
                    scrollPosition.X = pcbox.Width;
                }
                if(scrollPosition.Y > pcbox.Height)
                {
                    scrollPosition.Y = pcbox.Height;
                }
                this.panel1.AutoScrollPosition = scrollPosition;
                this.ResumeLayout();
            }
            if (bDrawingEnabled && e.Button == MouseButtons.Left && mouseDownPoint != Point.Empty)
            {
                try
                {
                    using(var canvas = Graphics.FromImage(pcbox.Image))
                    {
                        canvas.DrawLine(pn, mouseDownPoint, e.Location);
                            mouseDownPoint = e.Location;
                    }
                }
                catch
                {
                    bDrawingEnabled = false;
                }
                pcbox.Refresh();
            }
        }

        private void pcbox_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            if(bDrawingEnabled)
            {
                mouseDownPoint = Point.Empty;
            }
        }

        private void Form1_ResizeEnd_1(object sender, EventArgs e)
        {
            Size newSize = new Size(this.Size.Width - 110, this.Size.Height - 80);
            panel1.Size = newSize;
            pcbox.Size = newSize;
            panel1.HorizontalScroll.Value = 0;
            panel1.VerticalScroll.Value = 0;
            if (bmpImg != null)
            {
                ShowImage(bmpImg);
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if(colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Color.BackColor = colorDialog2.Color;
                pn.Dispose();
                pn = new Pen(Color.BackColor, (float)numericUpDown1.Value);
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif image|*.gif";
            save.Title = "Save an image file";
            if(pcbox.Image != null)
            {
                if(save.ShowDialog()!= DialogResult.Cancel)
                {
                    try
                    {
                        pcbox.Image.Save(save.FileName);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: Could not save file \"" +openFileDialog1.FileName + "\" to disk. Original error: " +ex.Message);
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pn.Dispose();
            pn = new Pen(Color.BackColor, (float)numericUpDown1.Value);
        }

        private void Grayscale_Click(object sender, EventArgs e)
        {
            if(pcbox.Image != null)
            {
                Cursor = Cursors.WaitCursor;
                Bitmap bmp = new Bitmap(pcbox.Image);
                for(int x=0; x<bmp.Width;x++)
                {
                    for(int y=0; y<bmp.Height;y++)
                    {
                        Color clr = bmp.GetPixel(x, y);
                        int v = (21 * clr.R + 71 * clr.G + 8 * clr.B) / 100;
                        bmp.SetPixel(x, y, Color.fromARGB(v, v, v));
                    }
                }
                Cursor = Cursors.Default;
                ShowImage(bmp);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
            if(a!=null)
            {
                strPathToLoadedImage = a.GetValue(0).ToString();
                Bitmap bmpFromClip = new Bitmap(strPathToLoadedImage);
                ShowImage(bmpFromClip);
            }
        }
    }
}
