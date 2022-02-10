namespace Studenti
{
    partial class DodadiOcenka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numOcena = new System.Windows.Forms.NumericUpDown();
            this.tbPredmet = new System.Windows.Forms.TextBox();
            this.tbCancel = new System.Windows.Forms.Button();
            this.tbVnesiOcena = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numOcena);
            this.groupBox1.Controls.Add(this.tbPredmet);
            this.groupBox1.Controls.Add(this.tbCancel);
            this.groupBox1.Controls.Add(this.tbVnesiOcena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numOcena
            // 
            this.numOcena.Location = new System.Drawing.Point(26, 149);
            this.numOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOcena.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOcena.Name = "numOcena";
            this.numOcena.Size = new System.Drawing.Size(120, 20);
            this.numOcena.TabIndex = 5;
            this.numOcena.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tbPredmet
            // 
            this.tbPredmet.Location = new System.Drawing.Point(26, 83);
            this.tbPredmet.Name = "tbPredmet";
            this.tbPredmet.Size = new System.Drawing.Size(100, 20);
            this.tbPredmet.TabIndex = 4;
            this.tbPredmet.Validating += new System.ComponentModel.CancelEventHandler(this.tbPredmet_Validating);
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(125, 237);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(75, 23);
            this.tbCancel.TabIndex = 3;
            this.tbCancel.Text = "Otkazi";
            this.tbCancel.UseVisualStyleBackColor = true;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
            // 
            // tbVnesiOcena
            // 
            this.tbVnesiOcena.Location = new System.Drawing.Point(26, 237);
            this.tbVnesiOcena.Name = "tbVnesiOcena";
            this.tbVnesiOcena.Size = new System.Drawing.Size(75, 23);
            this.tbVnesiOcena.TabIndex = 2;
            this.tbVnesiOcena.Text = "Vnesi";
            this.tbVnesiOcena.UseVisualStyleBackColor = true;
            this.tbVnesiOcena.Click += new System.EventHandler(this.tbVnesiOcena_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ocena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // DodadiOcenka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodadiOcenka";
            this.Text = "DodadiOcenka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numOcena;
        private System.Windows.Forms.TextBox tbPredmet;
        private System.Windows.Forms.Button tbCancel;
        private System.Windows.Forms.Button tbVnesiOcena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error2;
    }
}