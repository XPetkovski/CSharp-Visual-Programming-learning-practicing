namespace AV7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbWord = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiscovered = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.pbWrong = new System.Windows.Forms.ProgressBar();
            this.lbTime = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.Location = new System.Drawing.Point(13, 160);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(105, 31);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "lbWord";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(118, 194);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 69);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Погоди";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Погодени букви";
            // 
            // tbDiscovered
            // 
            this.tbDiscovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscovered.Location = new System.Drawing.Point(13, 309);
            this.tbDiscovered.Multiline = true;
            this.tbDiscovered.Name = "tbDiscovered";
            this.tbDiscovered.ReadOnly = true;
            this.tbDiscovered.Size = new System.Drawing.Size(467, 63);
            this.tbDiscovered.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(12, 390);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(468, 35);
            this.pbTime.TabIndex = 6;
            // 
            // pbWrong
            // 
            this.pbWrong.Location = new System.Drawing.Point(12, 441);
            this.pbWrong.Name = "pbWrong";
            this.pbWrong.Size = new System.Drawing.Size(468, 35);
            this.pbWrong.TabIndex = 7;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(200, 194);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 26);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "2:00";
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(19, 200);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(81, 20);
            this.tbLetter.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 633);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pbWrong);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.tbDiscovered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiscovered;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.ProgressBar pbWrong;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.MaskedTextBox tbLetter;
        //private System.Windows.Forms.ToolStripMenuItem newGame;
    }
}

