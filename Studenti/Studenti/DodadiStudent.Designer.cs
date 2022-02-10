namespace Studenti
{
    partial class DodadiStudent
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiStudent = new System.Windows.Forms.Button();
            this.btnCancelStudent = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(12, 70);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(203, 20);
            this.tbIme.TabIndex = 0;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(12, 141);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(203, 20);
            this.tbIndex.TabIndex = 1;
            this.tbIndex.Validating += new System.ComponentModel.CancelEventHandler(this.tbIndex_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Index";
            // 
            // btnDodadiStudent
            // 
            this.btnDodadiStudent.Location = new System.Drawing.Point(12, 184);
            this.btnDodadiStudent.Name = "btnDodadiStudent";
            this.btnDodadiStudent.Size = new System.Drawing.Size(102, 23);
            this.btnDodadiStudent.TabIndex = 4;
            this.btnDodadiStudent.Text = "Vnesi";
            this.btnDodadiStudent.UseVisualStyleBackColor = true;
            this.btnDodadiStudent.Click += new System.EventHandler(this.btnDodadiStudent_Click);
            // 
            // btnCancelStudent
            // 
            this.btnCancelStudent.Location = new System.Drawing.Point(120, 184);
            this.btnCancelStudent.Name = "btnCancelStudent";
            this.btnCancelStudent.Size = new System.Drawing.Size(95, 23);
            this.btnCancelStudent.TabIndex = 5;
            this.btnCancelStudent.Text = "Otkazi";
            this.btnCancelStudent.UseVisualStyleBackColor = true;
            this.btnCancelStudent.Click += new System.EventHandler(this.btnCancelStudent_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // DodadiStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 273);
            this.Controls.Add(this.btnCancelStudent);
            this.Controls.Add(this.btnDodadiStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.tbIme);
            this.Name = "DodadiStudent";
            this.Text = "DodadiStudent";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodadiStudent;
        private System.Windows.Forms.Button btnCancelStudent;
        private System.Windows.Forms.ErrorProvider error;
    }
}