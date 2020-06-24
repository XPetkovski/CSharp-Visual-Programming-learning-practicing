namespace AV6
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
            this.lbAerodromi = new System.Windows.Forms.ListBox();
            this.lbDestinacii = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.najskapaDestinacija = new System.Windows.Forms.TextBox();
            this.prosecnaDolzina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAerodromi
            // 
            this.lbAerodromi.FormattingEnabled = true;
            this.lbAerodromi.Location = new System.Drawing.Point(12, 32);
            this.lbAerodromi.Name = "lbAerodromi";
            this.lbAerodromi.Size = new System.Drawing.Size(334, 316);
            this.lbAerodromi.TabIndex = 0;
            this.lbAerodromi.SelectedIndexChanged += new System.EventHandler(this.lbAerodromi_SelectedIndexChanged);
            // 
            // lbDestinacii
            // 
            this.lbDestinacii.FormattingEnabled = true;
            this.lbDestinacii.Location = new System.Drawing.Point(352, 32);
            this.lbDestinacii.Name = "lbDestinacii";
            this.lbDestinacii.Size = new System.Drawing.Size(334, 316);
            this.lbDestinacii.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(334, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додади аеродром";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(15, 430);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(334, 23);
            this.btnDeleteAirport.TabIndex = 3;
            this.btnDeleteAirport.Text = "Избриши аеродром";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(13, 491);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(334, 23);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Аеродроми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дестинации";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prosecnaDolzina);
            this.groupBox1.Controls.Add(this.najskapaDestinacija);
            this.groupBox1.Location = new System.Drawing.Point(353, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 146);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // najskapaDestinacija
            // 
            this.najskapaDestinacija.Enabled = false;
            this.najskapaDestinacija.Location = new System.Drawing.Point(7, 46);
            this.najskapaDestinacija.Name = "najskapaDestinacija";
            this.najskapaDestinacija.Size = new System.Drawing.Size(321, 20);
            this.najskapaDestinacija.TabIndex = 0;
            // 
            // prosecnaDolzina
            // 
            this.prosecnaDolzina.Enabled = false;
            this.prosecnaDolzina.Location = new System.Drawing.Point(7, 93);
            this.prosecnaDolzina.Name = "prosecnaDolzina";
            this.prosecnaDolzina.Size = new System.Drawing.Size(321, 20);
            this.prosecnaDolzina.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Просечна должина на сите дестинации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDestinacii);
            this.Controls.Add(this.lbAerodromi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAerodromi;
        private System.Windows.Forms.ListBox lbDestinacii;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prosecnaDolzina;
        private System.Windows.Forms.TextBox najskapaDestinacija;
    }
}

