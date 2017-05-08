namespace ChiefKitchener.Forms
{
    partial class ProductBrowse
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
            this.ProductCombo = new System.Windows.Forms.ComboBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductMeasure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCombo
            // 
            this.ProductCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductCombo.FormattingEnabled = true;
            this.ProductCombo.Location = new System.Drawing.Point(12, 12);
            this.ProductCombo.Name = "ProductCombo";
            this.ProductCombo.Size = new System.Drawing.Size(335, 21);
            this.ProductCombo.TabIndex = 0;
            this.ProductCombo.SelectedIndexChanged += new System.EventHandler(this.ProductCombo_SelectedIndexChanged);
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 83);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(440, 160);
            this.ProductList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price";
            // 
            // ProductMeasure
            // 
            this.ProductMeasure.Location = new System.Drawing.Point(100, 53);
            this.ProductMeasure.Name = "ProductMeasure";
            this.ProductMeasure.Size = new System.Drawing.Size(77, 20);
            this.ProductMeasure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Measure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DecimalPlaces = 2;
            this.ProductQuantity.Location = new System.Drawing.Point(183, 53);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(61, 20);
            this.ProductQuantity.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(353, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add to stroe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddProduct);
            // 
            // ProductPrice
            // 
            this.ProductPrice.DecimalPlaces = 2;
            this.ProductPrice.Location = new System.Drawing.Point(12, 53);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(82, 20);
            this.ProductPrice.TabIndex = 5;
            // 
            // ExpDate
            // 
            this.ExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDate.Location = new System.Drawing.Point(252, 53);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(200, 20);
            this.ExpDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expiration date";
            // 
            // ProductBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductMeasure);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductCombo);
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "ProductBrowse";
            this.Text = "ProductBrowse";
            this.Load += new System.EventHandler(this.ProductBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCombo;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ProductQuantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown ProductPrice;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.Label label4;
    }
}