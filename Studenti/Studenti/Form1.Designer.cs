namespace Studenti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.lbOcena = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddOcena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProsecnaOcena = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddOcena);
            this.groupBox1.Controls.Add(this.btnDeleteStudent);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.lbStudent);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studenti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbProsecnaOcena);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbOcena);
            this.groupBox2.Location = new System.Drawing.Point(480, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 578);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocenki";
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.Location = new System.Drawing.Point(17, 39);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(384, 290);
            this.lbStudent.TabIndex = 0;
            this.lbStudent.SelectedIndexChanged += new System.EventHandler(this.lbStudent_SelectedIndexChanged);
            // 
            // lbOcena
            // 
            this.lbOcena.FormattingEnabled = true;
            this.lbOcena.Location = new System.Drawing.Point(29, 39);
            this.lbOcena.Name = "lbOcena";
            this.lbOcena.Size = new System.Drawing.Size(390, 290);
            this.lbOcena.TabIndex = 1;
            this.lbOcena.SelectedIndexChanged += new System.EventHandler(this.lbOcena_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(17, 353);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(384, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Dodadi student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(17, 403);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(384, 23);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Izbrisi Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddOcena
            // 
            this.btnAddOcena.Location = new System.Drawing.Point(17, 452);
            this.btnAddOcena.Name = "btnAddOcena";
            this.btnAddOcena.Size = new System.Drawing.Size(384, 68);
            this.btnAddOcena.TabIndex = 3;
            this.btnAddOcena.Text = "Dodadi ocenka";
            this.btnAddOcena.UseVisualStyleBackColor = true;
            this.btnAddOcena.Click += new System.EventHandler(this.btnAddOcena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prosecna ocena";
            // 
            // tbProsecnaOcena
            // 
            this.tbProsecnaOcena.Enabled = false;
            this.tbProsecnaOcena.Location = new System.Drawing.Point(32, 406);
            this.tbProsecnaOcena.Name = "tbProsecnaOcena";
            this.tbProsecnaOcena.Size = new System.Drawing.Size(387, 20);
            this.tbProsecnaOcena.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbOcena;
        private System.Windows.Forms.Button btnAddOcena;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox tbProsecnaOcena;
        private System.Windows.Forms.Label label1;
    }
}

