namespace IznajmuvanjeApartmani
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNajevtin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbApartmani = new System.Windows.Forms.ListBox();
            this.Gradovi = new System.Windows.Forms.GroupBox();
            this.lbCity = new System.Windows.Forms.ListBox();
            this.btnAddApartman = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.Gradovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNajevtin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbApartmani);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 578);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apartmani";
            // 
            // tbNajevtin
            // 
            this.tbNajevtin.Location = new System.Drawing.Point(19, 440);
            this.tbNajevtin.Name = "tbNajevtin";
            this.tbNajevtin.ReadOnly = true;
            this.tbNajevtin.Size = new System.Drawing.Size(296, 20);
            this.tbNajevtin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Najevtin apartman";
            // 
            // lbApartmani
            // 
            this.lbApartmani.FormattingEnabled = true;
            this.lbApartmani.Location = new System.Drawing.Point(16, 42);
            this.lbApartmani.Name = "lbApartmani";
            this.lbApartmani.Size = new System.Drawing.Size(299, 303);
            this.lbApartmani.TabIndex = 2;
            // 
            // Gradovi
            // 
            this.Gradovi.Controls.Add(this.lbCity);
            this.Gradovi.Controls.Add(this.btnAddApartman);
            this.Gradovi.Controls.Add(this.btnDelete);
            this.Gradovi.Controls.Add(this.btnAddCity);
            this.Gradovi.Location = new System.Drawing.Point(12, 12);
            this.Gradovi.Name = "Gradovi";
            this.Gradovi.Size = new System.Drawing.Size(353, 578);
            this.Gradovi.TabIndex = 5;
            this.Gradovi.TabStop = false;
            this.Gradovi.Text = "Gradovi";
            // 
            // lbCity
            // 
            this.lbCity.FormattingEnabled = true;
            this.lbCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCity.Location = new System.Drawing.Point(12, 42);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(323, 303);
            this.lbCity.TabIndex = 5;
            this.lbCity.SelectedIndexChanged += new System.EventHandler(this.lbCity_SelectedIndexChanged);
            // 
            // btnAddApartman
            // 
            this.btnAddApartman.Location = new System.Drawing.Point(12, 481);
            this.btnAddApartman.Name = "btnAddApartman";
            this.btnAddApartman.Size = new System.Drawing.Size(176, 23);
            this.btnAddApartman.TabIndex = 8;
            this.btnAddApartman.Text = "Додади апартман";
            this.btnAddApartman.UseVisualStyleBackColor = true;
            this.btnAddApartman.Click += new System.EventHandler(this.btnAddApartman_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Избриши град";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(12, 370);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(176, 23);
            this.btnAddCity.TabIndex = 6;
            this.btnAddCity.Text = "Додади град";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Gradovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Gradovi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNajevtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbApartmani;
        private System.Windows.Forms.GroupBox Gradovi;
        private System.Windows.Forms.Button btnAddApartman;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.ListBox lbCity;
    }
}

