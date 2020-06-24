namespace Predavanje5
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bntOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblImgSize = new System.Windows.Forms.Label();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Scale = new System.Windows.Forms.CheckBox();
            this.Zoom = new System.Windows.Forms.CheckBox();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LineWidth = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.GrayScale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // bntOpen
            // 
            this.bntOpen.Location = new System.Drawing.Point(3, 3);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(75, 40);
            this.bntOpen.TabIndex = 0;
            this.bntOpen.Text = "Open";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "File Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // lblImgSize
            // 
            this.lblImgSize.AutoSize = true;
            this.lblImgSize.Location = new System.Drawing.Point(807, 17);
            this.lblImgSize.Name = "lblImgSize";
            this.lblImgSize.Size = new System.Drawing.Size(127, 13);
            this.lblImgSize.TabIndex = 4;
            this.lblImgSize.Text = "Resolution (nebitno sega)";
            this.lblImgSize.Click += new System.EventHandler(this.lblImgSize_Click);
            // 
            // pcbox
            // 
            this.pcbox.Location = new System.Drawing.Point(173, 49);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(710, 524);
            this.pcbox.TabIndex = 5;
            this.pcbox.TabStop = false;
            this.pcbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbox_MouseDown);
            this.pcbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbox_MouseMove);
            this.pcbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.GrayScale);
            this.panel1.Controls.Add(this.LineWidth);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.Color);
            this.panel1.Controls.Add(this.SaveAs);
            this.panel1.Controls.Add(this.Scale);
            this.panel1.Controls.Add(this.Zoom);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblImgSize);
            this.panel1.Controls.Add(this.bntOpen);
            this.panel1.Controls.Add(this.pcbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 602);
            this.panel1.TabIndex = 6;
            // 
            // Scale
            // 
            this.Scale.AutoSize = true;
            this.Scale.Location = new System.Drawing.Point(3, 72);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(70, 17);
            this.Scale.TabIndex = 7;
            this.Scale.Text = "Scale big";
            this.Scale.UseVisualStyleBackColor = true;
            this.Scale.CheckedChanged += new System.EventHandler(this.Scale_CheckedChanged);
            // 
            // Zoom
            // 
            this.Zoom.AutoSize = true;
            this.Zoom.Location = new System.Drawing.Point(3, 49);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(79, 17);
            this.Zoom.TabIndex = 6;
            this.Zoom.Text = "Zoom small";
            this.Zoom.UseVisualStyleBackColor = true;
            this.Zoom.CheckedChanged += new System.EventHandler(this.Zoom_CheckedChanged);
            this.Zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(7, 155);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(75, 23);
            this.SaveAs.TabIndex = 8;
            this.SaveAs.Text = "SaveAs";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(7, 209);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(75, 23);
            this.Color.TabIndex = 9;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(7, 280);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LineWidth
            // 
            this.LineWidth.AutoSize = true;
            this.LineWidth.Location = new System.Drawing.Point(7, 261);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(55, 13);
            this.LineWidth.TabIndex = 11;
            this.LineWidth.Text = "Line width";
            // 
            // GrayScale
            // 
            this.GrayScale.Location = new System.Drawing.Point(7, 307);
            this.GrayScale.Name = "GrayScale";
            this.GrayScale.Size = new System.Drawing.Size(75, 23);
            this.GrayScale.TabIndex = 12;
            this.GrayScale.Text = "Grayscale";
            this.GrayScale.UseVisualStyleBackColor = true;
            this.GrayScale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 626);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd_1);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblImgSize;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Scale;
        private System.Windows.Forms.CheckBox Zoom;
        private System.Windows.Forms.Label LineWidth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button GrayScale;
    }
}

