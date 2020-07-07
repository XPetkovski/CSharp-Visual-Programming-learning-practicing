namespace NarackaPizza
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
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.tbLarge = new System.Windows.Forms.TextBox();
            this.tbMedium = new System.Windows.Forms.TextBox();
            this.tbSmall = new System.Windows.Forms.TextBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gpAddons = new System.Windows.Forms.GroupBox();
            this.tbKetchup = new System.Windows.Forms.TextBox();
            this.tbCheese = new System.Windows.Forms.TextBox();
            this.tbFeferons = new System.Windows.Forms.TextBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbFeferons = new System.Windows.Forms.CheckBox();
            this.gpDrink = new System.Windows.Forms.GroupBox();
            this.tbTotalDrink3 = new System.Windows.Forms.TextBox();
            this.tbTotalDrink2 = new System.Windows.Forms.TextBox();
            this.tbTotalDrink1 = new System.Windows.Forms.TextBox();
            this.tbPriceBeer = new System.Windows.Forms.TextBox();
            this.tbPriceJuice = new System.Windows.Forms.TextBox();
            this.tbPriceCoke = new System.Windows.Forms.TextBox();
            this.tbBeer = new System.Windows.Forms.TextBox();
            this.tbQuantityJuice = new System.Windows.Forms.TextBox();
            this.tbCoke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpDesert = new System.Windows.Forms.GroupBox();
            this.tbCake = new System.Windows.Forms.TextBox();
            this.tbIceCream = new System.Windows.Forms.TextBox();
            this.tbFruitPie = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbCake = new System.Windows.Forms.RadioButton();
            this.rbIceCream = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.rbFruitPie = new System.Windows.Forms.RadioButton();
            this.gpTotal = new System.Windows.Forms.GroupBox();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpSize.SuspendLayout();
            this.gpAddons.SuspendLayout();
            this.gpDrink.SuspendLayout();
            this.gpDesert.SuspendLayout();
            this.gpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.tbLarge);
            this.gpSize.Controls.Add(this.tbMedium);
            this.gpSize.Controls.Add(this.tbSmall);
            this.gpSize.Controls.Add(this.rbLarge);
            this.gpSize.Controls.Add(this.rbMedium);
            this.gpSize.Controls.Add(this.rbSmall);
            this.gpSize.Location = new System.Drawing.Point(13, 13);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(275, 144);
            this.gpSize.TabIndex = 0;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // tbLarge
            // 
            this.tbLarge.Location = new System.Drawing.Point(157, 97);
            this.tbLarge.Name = "tbLarge";
            this.tbLarge.Size = new System.Drawing.Size(100, 20);
            this.tbLarge.TabIndex = 5;
            this.tbLarge.Text = "500";
            // 
            // tbMedium
            // 
            this.tbMedium.Location = new System.Drawing.Point(157, 63);
            this.tbMedium.Name = "tbMedium";
            this.tbMedium.Size = new System.Drawing.Size(100, 20);
            this.tbMedium.TabIndex = 4;
            this.tbMedium.Text = "300";
            // 
            // tbSmall
            // 
            this.tbSmall.Location = new System.Drawing.Point(157, 31);
            this.tbSmall.Name = "tbSmall";
            this.tbSmall.Size = new System.Drawing.Size(100, 20);
            this.tbSmall.TabIndex = 3;
            this.tbSmall.Text = "200";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(9, 100);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(9, 67);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(9, 34);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gpAddons
            // 
            this.gpAddons.Controls.Add(this.tbKetchup);
            this.gpAddons.Controls.Add(this.tbCheese);
            this.gpAddons.Controls.Add(this.tbFeferons);
            this.gpAddons.Controls.Add(this.cbKetchup);
            this.gpAddons.Controls.Add(this.cbCheese);
            this.gpAddons.Controls.Add(this.cbFeferons);
            this.gpAddons.Location = new System.Drawing.Point(306, 13);
            this.gpAddons.Name = "gpAddons";
            this.gpAddons.Size = new System.Drawing.Size(302, 144);
            this.gpAddons.TabIndex = 1;
            this.gpAddons.TabStop = false;
            this.gpAddons.Text = "Add-ons";
            // 
            // tbKetchup
            // 
            this.tbKetchup.Location = new System.Drawing.Point(162, 101);
            this.tbKetchup.Name = "tbKetchup";
            this.tbKetchup.Size = new System.Drawing.Size(100, 20);
            this.tbKetchup.TabIndex = 5;
            this.tbKetchup.Text = "20";
            // 
            // tbCheese
            // 
            this.tbCheese.Location = new System.Drawing.Point(162, 67);
            this.tbCheese.Name = "tbCheese";
            this.tbCheese.Size = new System.Drawing.Size(100, 20);
            this.tbCheese.TabIndex = 4;
            this.tbCheese.Text = "30";
            // 
            // tbFeferons
            // 
            this.tbFeferons.Location = new System.Drawing.Point(162, 33);
            this.tbFeferons.Name = "tbFeferons";
            this.tbFeferons.Size = new System.Drawing.Size(100, 20);
            this.tbFeferons.TabIndex = 3;
            this.tbFeferons.Text = "40";
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(28, 101);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(66, 17);
            this.cbKetchup.TabIndex = 2;
            this.cbKetchup.Text = "Ketchup";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.cbKetchup_CheckedChanged);
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(28, 66);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(88, 17);
            this.cbCheese.TabIndex = 1;
            this.cbCheese.Text = "Extra cheese";
            this.cbCheese.UseVisualStyleBackColor = true;
            this.cbCheese.CheckedChanged += new System.EventHandler(this.cbCheese_CheckedChanged);
            // 
            // cbFeferons
            // 
            this.cbFeferons.AutoSize = true;
            this.cbFeferons.Location = new System.Drawing.Point(28, 34);
            this.cbFeferons.Name = "cbFeferons";
            this.cbFeferons.Size = new System.Drawing.Size(67, 17);
            this.cbFeferons.TabIndex = 0;
            this.cbFeferons.Text = "Feferons";
            this.cbFeferons.UseVisualStyleBackColor = true;
            this.cbFeferons.CheckedChanged += new System.EventHandler(this.cbFeferons_CheckedChanged);
            // 
            // gpDrink
            // 
            this.gpDrink.Controls.Add(this.tbTotalDrink3);
            this.gpDrink.Controls.Add(this.tbTotalDrink2);
            this.gpDrink.Controls.Add(this.tbTotalDrink1);
            this.gpDrink.Controls.Add(this.tbPriceBeer);
            this.gpDrink.Controls.Add(this.tbPriceJuice);
            this.gpDrink.Controls.Add(this.tbPriceCoke);
            this.gpDrink.Controls.Add(this.tbBeer);
            this.gpDrink.Controls.Add(this.tbQuantityJuice);
            this.gpDrink.Controls.Add(this.tbCoke);
            this.gpDrink.Controls.Add(this.label6);
            this.gpDrink.Controls.Add(this.label5);
            this.gpDrink.Controls.Add(this.label4);
            this.gpDrink.Controls.Add(this.label3);
            this.gpDrink.Controls.Add(this.label2);
            this.gpDrink.Controls.Add(this.label1);
            this.gpDrink.Location = new System.Drawing.Point(13, 178);
            this.gpDrink.Name = "gpDrink";
            this.gpDrink.Size = new System.Drawing.Size(595, 178);
            this.gpDrink.TabIndex = 1;
            this.gpDrink.TabStop = false;
            this.gpDrink.Text = "Drink";
            // 
            // tbTotalDrink3
            // 
            this.tbTotalDrink3.Location = new System.Drawing.Point(463, 123);
            this.tbTotalDrink3.Name = "tbTotalDrink3";
            this.tbTotalDrink3.Size = new System.Drawing.Size(100, 20);
            this.tbTotalDrink3.TabIndex = 14;
            this.tbTotalDrink3.Click += new System.EventHandler(this.tbTotalDrink3_Click);
            // 
            // tbTotalDrink2
            // 
            this.tbTotalDrink2.Location = new System.Drawing.Point(463, 90);
            this.tbTotalDrink2.Name = "tbTotalDrink2";
            this.tbTotalDrink2.Size = new System.Drawing.Size(100, 20);
            this.tbTotalDrink2.TabIndex = 13;
            this.tbTotalDrink2.Click += new System.EventHandler(this.tbTotalDrink2_Click_1);
            // 
            // tbTotalDrink1
            // 
            this.tbTotalDrink1.Location = new System.Drawing.Point(463, 62);
            this.tbTotalDrink1.Name = "tbTotalDrink1";
            this.tbTotalDrink1.Size = new System.Drawing.Size(100, 20);
            this.tbTotalDrink1.TabIndex = 12;
            this.tbTotalDrink1.Click += new System.EventHandler(this.tbTotalDrink1_Click);
            // 
            // tbPriceBeer
            // 
            this.tbPriceBeer.Location = new System.Drawing.Point(345, 123);
            this.tbPriceBeer.Name = "tbPriceBeer";
            this.tbPriceBeer.ReadOnly = true;
            this.tbPriceBeer.Size = new System.Drawing.Size(100, 20);
            this.tbPriceBeer.TabIndex = 11;
            this.tbPriceBeer.Text = "80";
            // 
            // tbPriceJuice
            // 
            this.tbPriceJuice.Location = new System.Drawing.Point(345, 90);
            this.tbPriceJuice.Name = "tbPriceJuice";
            this.tbPriceJuice.ReadOnly = true;
            this.tbPriceJuice.Size = new System.Drawing.Size(100, 20);
            this.tbPriceJuice.TabIndex = 10;
            this.tbPriceJuice.Text = "70";
            // 
            // tbPriceCoke
            // 
            this.tbPriceCoke.Location = new System.Drawing.Point(345, 62);
            this.tbPriceCoke.Name = "tbPriceCoke";
            this.tbPriceCoke.ReadOnly = true;
            this.tbPriceCoke.Size = new System.Drawing.Size(100, 20);
            this.tbPriceCoke.TabIndex = 9;
            this.tbPriceCoke.Text = "60";
            // 
            // tbBeer
            // 
            this.tbBeer.Location = new System.Drawing.Point(225, 123);
            this.tbBeer.Name = "tbBeer";
            this.tbBeer.Size = new System.Drawing.Size(100, 20);
            this.tbBeer.TabIndex = 8;
            this.tbBeer.Text = "0";
            // 
            // tbQuantityJuice
            // 
            this.tbQuantityJuice.Location = new System.Drawing.Point(225, 90);
            this.tbQuantityJuice.Name = "tbQuantityJuice";
            this.tbQuantityJuice.Size = new System.Drawing.Size(100, 20);
            this.tbQuantityJuice.TabIndex = 7;
            this.tbQuantityJuice.Text = "0";
            // 
            // tbCoke
            // 
            this.tbCoke.Location = new System.Drawing.Point(225, 62);
            this.tbCoke.Name = "tbCoke";
            this.tbCoke.Size = new System.Drawing.Size(100, 20);
            this.tbCoke.TabIndex = 6;
            this.tbCoke.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apple Juice / Orange Juice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coca-Cola / Fanta / Sprite";
            // 
            // gpDesert
            // 
            this.gpDesert.Controls.Add(this.tbCake);
            this.gpDesert.Controls.Add(this.tbIceCream);
            this.gpDesert.Controls.Add(this.tbFruitPie);
            this.gpDesert.Controls.Add(this.btnCancel);
            this.gpDesert.Controls.Add(this.rbCake);
            this.gpDesert.Controls.Add(this.rbIceCream);
            this.gpDesert.Controls.Add(this.btnOrder);
            this.gpDesert.Controls.Add(this.rbFruitPie);
            this.gpDesert.Location = new System.Drawing.Point(13, 373);
            this.gpDesert.Name = "gpDesert";
            this.gpDesert.Size = new System.Drawing.Size(297, 179);
            this.gpDesert.TabIndex = 1;
            this.gpDesert.TabStop = false;
            this.gpDesert.Text = "Desert";
            // 
            // tbCake
            // 
            this.tbCake.Location = new System.Drawing.Point(146, 94);
            this.tbCake.Name = "tbCake";
            this.tbCake.Size = new System.Drawing.Size(100, 20);
            this.tbCake.TabIndex = 10;
            this.tbCake.Text = "160";
            // 
            // tbIceCream
            // 
            this.tbIceCream.Location = new System.Drawing.Point(146, 66);
            this.tbIceCream.Name = "tbIceCream";
            this.tbIceCream.Size = new System.Drawing.Size(100, 20);
            this.tbIceCream.TabIndex = 9;
            this.tbIceCream.Text = "120";
            // 
            // tbFruitPie
            // 
            this.tbFruitPie.Location = new System.Drawing.Point(146, 34);
            this.tbFruitPie.Name = "tbFruitPie";
            this.tbFruitPie.Size = new System.Drawing.Size(100, 20);
            this.tbFruitPie.TabIndex = 8;
            this.tbFruitPie.Text = "80";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbCake
            // 
            this.rbCake.AutoSize = true;
            this.rbCake.Location = new System.Drawing.Point(9, 94);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(50, 17);
            this.rbCake.TabIndex = 7;
            this.rbCake.TabStop = true;
            this.rbCake.Text = "Cake";
            this.rbCake.UseVisualStyleBackColor = true;
            this.rbCake.CheckedChanged += new System.EventHandler(this.rbCake_CheckedChanged);
            // 
            // rbIceCream
            // 
            this.rbIceCream.AutoSize = true;
            this.rbIceCream.Location = new System.Drawing.Point(9, 66);
            this.rbIceCream.Name = "rbIceCream";
            this.rbIceCream.Size = new System.Drawing.Size(73, 17);
            this.rbIceCream.TabIndex = 6;
            this.rbIceCream.TabStop = true;
            this.rbIceCream.Text = "Ice Cream";
            this.rbIceCream.UseVisualStyleBackColor = true;
            this.rbIceCream.CheckedChanged += new System.EventHandler(this.rbIceCream_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(38, 134);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(101, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // rbFruitPie
            // 
            this.rbFruitPie.AutoSize = true;
            this.rbFruitPie.Location = new System.Drawing.Point(9, 34);
            this.rbFruitPie.Name = "rbFruitPie";
            this.rbFruitPie.Size = new System.Drawing.Size(62, 17);
            this.rbFruitPie.TabIndex = 5;
            this.rbFruitPie.TabStop = true;
            this.rbFruitPie.Text = "Fruit pie";
            this.rbFruitPie.UseVisualStyleBackColor = true;
            this.rbFruitPie.CheckedChanged += new System.EventHandler(this.rbFruitPie_CheckedChanged);
            // 
            // gpTotal
            // 
            this.gpTotal.Controls.Add(this.tbReturn);
            this.gpTotal.Controls.Add(this.tbPay);
            this.gpTotal.Controls.Add(this.tbTotal);
            this.gpTotal.Controls.Add(this.label10);
            this.gpTotal.Controls.Add(this.label9);
            this.gpTotal.Controls.Add(this.label8);
            this.gpTotal.Location = new System.Drawing.Point(334, 373);
            this.gpTotal.Name = "gpTotal";
            this.gpTotal.Size = new System.Drawing.Size(274, 179);
            this.gpTotal.TabIndex = 1;
            this.gpTotal.TabStop = false;
            this.gpTotal.Text = "Total Payment";
            // 
            // tbReturn
            // 
            this.tbReturn.Location = new System.Drawing.Point(100, 131);
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.Size = new System.Drawing.Size(100, 20);
            this.tbReturn.TabIndex = 5;
            // 
            // tbPay
            // 
            this.tbPay.Location = new System.Drawing.Point(100, 91);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(100, 20);
            this.tbPay.TabIndex = 4;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(100, 51);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "To return: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Price to pay: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 598);
            this.Controls.Add(this.gpAddons);
            this.Controls.Add(this.gpDrink);
            this.Controls.Add(this.gpDesert);
            this.Controls.Add(this.gpTotal);
            this.Controls.Add(this.gpSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpAddons.ResumeLayout(false);
            this.gpAddons.PerformLayout();
            this.gpDrink.ResumeLayout(false);
            this.gpDrink.PerformLayout();
            this.gpDesert.ResumeLayout(false);
            this.gpDesert.PerformLayout();
            this.gpTotal.ResumeLayout(false);
            this.gpTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.TextBox tbLarge;
        private System.Windows.Forms.TextBox tbMedium;
        private System.Windows.Forms.TextBox tbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gpAddons;
        private System.Windows.Forms.TextBox tbKetchup;
        private System.Windows.Forms.TextBox tbCheese;
        private System.Windows.Forms.TextBox tbFeferons;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbFeferons;
        private System.Windows.Forms.GroupBox gpDrink;
        private System.Windows.Forms.TextBox tbTotalDrink3;
        private System.Windows.Forms.TextBox tbTotalDrink2;
        private System.Windows.Forms.TextBox tbTotalDrink1;
        private System.Windows.Forms.TextBox tbPriceBeer;
        private System.Windows.Forms.TextBox tbPriceJuice;
        private System.Windows.Forms.TextBox tbPriceCoke;
        private System.Windows.Forms.TextBox tbBeer;
        private System.Windows.Forms.TextBox tbQuantityJuice;
        private System.Windows.Forms.TextBox tbCoke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpDesert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gpTotal;
        private System.Windows.Forms.TextBox tbReturn;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCake;
        private System.Windows.Forms.TextBox tbIceCream;
        private System.Windows.Forms.TextBox tbFruitPie;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.RadioButton rbIceCream;
        private System.Windows.Forms.RadioButton rbFruitPie;
    }
}

