namespace AV4_5
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
            this.lbChecked = new System.Windows.Forms.CheckedListBox();
            this.tbString = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntDeleteChecked = new System.Windows.Forms.Button();
            this.lbSimple = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbChecked
            // 
            this.lbChecked.FormattingEnabled = true;
            this.lbChecked.Location = new System.Drawing.Point(906, 141);
            this.lbChecked.Name = "lbChecked";
            this.lbChecked.Size = new System.Drawing.Size(368, 364);
            this.lbChecked.TabIndex = 1;
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(187, 141);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(194, 20);
            this.tbString.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(368, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bntDeleteChecked
            // 
            this.bntDeleteChecked.Location = new System.Drawing.Point(906, 526);
            this.bntDeleteChecked.Name = "bntDeleteChecked";
            this.bntDeleteChecked.Size = new System.Drawing.Size(368, 23);
            this.bntDeleteChecked.TabIndex = 5;
            this.bntDeleteChecked.Text = "DELETE";
            this.bntDeleteChecked.UseVisualStyleBackColor = true;
            this.bntDeleteChecked.Click += new System.EventHandler(this.bntDeleteChecked_Click);
            // 
            // lbSimple
            // 
            this.lbSimple.FormattingEnabled = true;
            this.lbSimple.Location = new System.Drawing.Point(490, 137);
            this.lbSimple.Name = "lbSimple";
            this.lbSimple.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSimple.Size = new System.Drawing.Size(368, 368);
            this.lbSimple.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 664);
            this.Controls.Add(this.lbSimple);
            this.Controls.Add(this.bntDeleteChecked);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.lbChecked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox lbChecked;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntDeleteChecked;
        private System.Windows.Forms.ListBox lbSimple;
    }
}

