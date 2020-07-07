namespace PotrosuvackaKosnicka
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnEmptyPL = new System.Windows.Forms.Button();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbProductD = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.gbProductD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(39, 64);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(281, 342);
            this.lbProducts.TabIndex = 0;
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.Location = new System.Drawing.Point(563, 64);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(253, 303);
            this.lbCart.TabIndex = 1;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(341, 221);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(200, 23);
            this.btnAddCart.TabIndex = 2;
            this.btnAddCart.Text = "AddToCart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Location = new System.Drawing.Point(341, 264);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteCart.TabIndex = 3;
            this.btnDeleteCart.Text = "Delete from cart";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(341, 306);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(200, 23);
            this.btnAddP.TabIndex = 4;
            this.btnAddP.Text = "Add new product";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Location = new System.Drawing.Point(341, 344);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteP.TabIndex = 5;
            this.btnDeleteP.Text = "Delete product";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnEmptyPL
            // 
            this.btnEmptyPL.Location = new System.Drawing.Point(39, 420);
            this.btnEmptyPL.Name = "btnEmptyPL";
            this.btnEmptyPL.Size = new System.Drawing.Size(281, 23);
            this.btnEmptyPL.TabIndex = 6;
            this.btnEmptyPL.Text = "Empty the product list?";
            this.btnEmptyPL.UseVisualStyleBackColor = true;
            this.btnEmptyPL.Click += new System.EventHandler(this.btnEmptyPL_Click);
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(563, 420);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(253, 23);
            this.btnEmptyCart.TabIndex = 7;
            this.btnEmptyCart.Text = "Empty the cart?";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cart:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total: ";
            // 
            // gbProductD
            // 
            this.gbProductD.Controls.Add(this.tbPrice);
            this.gbProductD.Controls.Add(this.tbCategory);
            this.gbProductD.Controls.Add(this.tbName);
            this.gbProductD.Controls.Add(this.label6);
            this.gbProductD.Controls.Add(this.label5);
            this.gbProductD.Controls.Add(this.label4);
            this.gbProductD.Location = new System.Drawing.Point(341, 64);
            this.gbProductD.Name = "gbProductD";
            this.gbProductD.Size = new System.Drawing.Size(200, 143);
            this.gbProductD.TabIndex = 11;
            this.gbProductD.TabStop = false;
            this.gbProductD.Text = "Product Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 32);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(185, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(9, 74);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(185, 20);
            this.tbCategory.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(9, 113);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(185, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(603, 383);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(212, 20);
            this.tbTotal.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 476);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.gbProductD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmptyCart);
            this.Controls.Add(this.btnEmptyPL);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.btnDeleteCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.lbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbProductD.ResumeLayout(false);
            this.gbProductD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnDeleteCart;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnEmptyPL;
        private System.Windows.Forms.Button btnEmptyCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbProductD;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotal;
    }
}

