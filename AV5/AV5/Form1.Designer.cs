namespace AV5
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
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddGame2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.nudCoef1 = new System.Windows.Forms.NumericUpDown();
            this.nudCoefX = new System.Windows.Forms.NumericUpDown();
            this.nudCoef2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoefX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(12, 25);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTeams.Size = new System.Drawing.Size(325, 290);
            this.lbTeams.TabIndex = 0;
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.Location = new System.Drawing.Point(409, 25);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(325, 290);
            this.lbGames.TabIndex = 1;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.Location = new System.Drawing.Point(817, 25);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbTickets.Size = new System.Drawing.Size(325, 290);
            this.lbTickets.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Додади тим";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Креирај натпревар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Х";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Избери тип";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(409, 413);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(325, 40);
            this.btnAddGame.TabIndex = 10;
            this.btnAddGame.Text = "Додади натпревар";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.BtnAddToTicket);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Уплата";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Вкупен коефициент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(817, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Добивка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Тимови";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Игри";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(817, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Тикети";
            // 
            // btnAddGame2
            // 
            this.btnAddGame2.Location = new System.Drawing.Point(19, 563);
            this.btnAddGame2.Name = "btnAddGame2";
            this.btnAddGame2.Size = new System.Drawing.Size(184, 23);
            this.btnAddGame2.TabIndex = 19;
            this.btnAddGame2.Text = "Додади во билтен";
            this.btnAddGame2.UseVisualStyleBackColor = true;
            this.btnAddGame2.Click += new System.EventHandler(this.btnAddGame_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 539);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Шифра";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(68, 536);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(135, 20);
            this.tbCode.TabIndex = 21;
            // 
            // nudCoef1
            // 
            this.nudCoef1.DecimalPlaces = 2;
            this.nudCoef1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudCoef1.Location = new System.Drawing.Point(68, 399);
            this.nudCoef1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCoef1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoef1.Name = "nudCoef1";
            this.nudCoef1.Size = new System.Drawing.Size(120, 20);
            this.nudCoef1.TabIndex = 22;
            this.nudCoef1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCoefX
            // 
            this.nudCoefX.DecimalPlaces = 2;
            this.nudCoefX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudCoefX.Location = new System.Drawing.Point(68, 425);
            this.nudCoefX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCoefX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoefX.Name = "nudCoefX";
            this.nudCoefX.Size = new System.Drawing.Size(120, 20);
            this.nudCoefX.TabIndex = 23;
            this.nudCoefX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCoef2
            // 
            this.nudCoef2.DecimalPlaces = 2;
            this.nudCoef2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudCoef2.Location = new System.Drawing.Point(68, 453);
            this.nudCoef2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCoef2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoef2.Name = "nudCoef2";
            this.nudCoef2.Size = new System.Drawing.Size(120, 20);
            this.nudCoef2.TabIndex = 24;
            this.nudCoef2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(490, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 652);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nudCoef2);
            this.Controls.Add(this.nudCoefX);
            this.Controls.Add(this.nudCoef1);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAddGame2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.lbTeams);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoefX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddToTicket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddGame2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.NumericUpDown nudCoef1;
        private System.Windows.Forms.NumericUpDown nudCoefX;
        private System.Windows.Forms.NumericUpDown nudCoef2;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddGame;
    }
}

