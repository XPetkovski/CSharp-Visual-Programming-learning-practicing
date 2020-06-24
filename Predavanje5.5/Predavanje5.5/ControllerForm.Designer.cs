namespace Predavanje5._5
{
    partial class ControllerForm
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
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.tbNumCoins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PileView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(12, 96);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(44, 50);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(12, 152);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(44, 50);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // tbNumCoins
            // 
            this.tbNumCoins.Enabled = false;
            this.tbNumCoins.Location = new System.Drawing.Point(76, 110);
            this.tbNumCoins.Multiline = true;
            this.tbNumCoins.Name = "tbNumCoins";
            this.tbNumCoins.Size = new System.Drawing.Size(100, 91);
            this.tbNumCoins.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "# of coins";
            // 
            // PileView
            // 
            this.PileView.Location = new System.Drawing.Point(198, 96);
            this.PileView.Name = "PileView";
            this.PileView.Size = new System.Drawing.Size(75, 105);
            this.PileView.TabIndex = 4;
            this.PileView.Text = "New coin pile view";
            this.PileView.UseVisualStyleBackColor = true;
            this.PileView.Click += new System.EventHandler(this.PileView_Click);
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 273);
            this.Controls.Add(this.PileView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumCoins);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Name = "ControllerForm";
            this.Text = "ControllerForm";
            this.Load += new System.EventHandler(this.ControllerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.TextBox tbNumCoins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PileView;
    }
}