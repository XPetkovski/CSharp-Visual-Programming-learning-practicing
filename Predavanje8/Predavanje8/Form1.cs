using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct SearchArgs
        {
            public string Fname { get; private set; }
            public string key { get; private set; }
            public StringComparison CompareType { get; private set; }
            public SearchArgs(string Fname, string key, StringComparison CompareType = StringComparison.OrdinalIgnoreCase)
            {
                this.Fname = Fname;
                this.key = key;
                this.CompareType = CompareType;
            }
        }

        public struct SearchResults
        {
            public long Wcnt { get; private set; }
            public long Lcnt { get; private set; }
            public SearchResults(long Wcnt, long Lcnt)
            {
                this.Wcnt = Wcnt;
                this.Lcnt = Lcnt;
            }
        }

        public SearchResults Find(SearchArgs args)
        {
            string file = args.Fname;
            string key = args.key;
            StringComparison ct = args.CompareType;
            long wordCnt = 0;
            long lineCnt = 0;
            if(File.Exists(file)&&key!=null && key != System.String.Empty)
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        int found, from;
                        if ((from = s.IndexOf(key, ct)) >= 0)
                        {
                            wordCnt++;
                            lineCnt++;
                            while ((found = s.IndexOf(key, from + 1, ct)) >= 0)
                            {
                                wordCnt++;
                                from = found;
                            }
                        }
                    }
                }
            }
            return new SearchResults(wordCnt, lineCnt);
        }

        public void Find(string file, string key, out int wordCnt, out int lineCnt)
        {
            wordCnt = lineCnt = 0;
            if(File.Exists(file))
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        int found, from;
                        if((from = s.IndexOf(key, StringComparison.OrdinalIgnoreCase))>=0)
                        {
                            wordCnt++;
                            lineCnt++;
                            while((found=s.IndexOf(key, from+1,StringComparison.OrdinalIgnoreCase))>=0)
                            {
                                wordCnt++;
                                from = found;
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //start
        {
            int wc, lc;
            Find(textBoxFileName.Text, textBoxWord.Text, out wc, out lc);
            labelResult.Text = string.Format("The word \"{0}\"\n was found {1} times in {2} lines.", textBoxWord.Text, wc, lc);
            labelStatus.Visible = true;
            labelStatus.Text = "Searching...";
            labelStatus.Update();
            SearchResults res = Find(new SearchArgs(textBoxFileName.Text, textBoxWord.Text));
            labelResult.Text = string.Format("The word \"{0}\"\n was found {1}times in {2} lines.", textBoxWord.Text, res.Wcnt, res.Lcnt);
            labelStatus.Visible = false;
            labelStatus.Update();

            backgroundWorker1.RunWorkerAsync(new SearchArgs(textBoxFileName.Text, textBoxWord.Text));
        }

        private void button1_Click(object sender, EventArgs e) //file selector
        {
            if(openFileDialog.ShowDialog()!= DialogResult.Cancel)
            {
                textBoxFileName.Text = openFileDialog.FileName;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Find((SearchArgs)e.Argument);
        }

        private void button3_Click(object sender, EventArgs e) //stop
        {
            //stop = true;
            button3.Enabled = false;
        }
    }
}
