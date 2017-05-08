namespace ChiefKitchener.Forms
{
    partial class RecipeBrowse
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
            this.RecipeList = new System.Windows.Forms.ComboBox();
            this.RecipeDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.ComboBox();
            this.ProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecipeList
            // 
            this.RecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RecipeList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RecipeList.FormattingEnabled = true;
            this.RecipeList.Location = new System.Drawing.Point(18, 18);
            this.RecipeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecipeList.Name = "RecipeList";
            this.RecipeList.Size = new System.Drawing.Size(664, 28);
            this.RecipeList.TabIndex = 0;
            this.RecipeList.SelectedIndexChanged += new System.EventHandler(this.RecipeList_SelectedIndexChanged);
            // 
            // RecipeDescription
            // 
            this.RecipeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecipeDescription.Location = new System.Drawing.Point(4, 24);
            this.RecipeDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecipeDescription.Name = "RecipeDescription";
            this.RecipeDescription.Size = new System.Drawing.Size(486, 463);
            this.RecipeDescription.TabIndex = 2;
            this.RecipeDescription.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(810, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveRecipe);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(693, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteRecipe);
            // 
            // ProductName
            // 
            this.ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductName.FormattingEnabled = true;
            this.ProductName.Location = new System.Drawing.Point(9, 29);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(259, 28);
            this.ProductName.TabIndex = 6;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductQuantity.DecimalPlaces = 2;
            this.ProductQuantity.Location = new System.Drawing.Point(279, 31);
            this.ProductQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(110, 26);
            this.ProductQuantity.TabIndex = 7;
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 20;
            this.ProductList.Location = new System.Drawing.Point(9, 108);
            this.ProductList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(378, 364);
            this.ProductList.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.ProductList);
            this.groupBox1.Controls.Add(this.ProductQuantity);
            this.groupBox1.Location = new System.Drawing.Point(18, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(398, 492);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddProductInRecipe);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteProductFromRecipe);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RecipeDescription);
            this.groupBox2.Location = new System.Drawing.Point(424, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(494, 492);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipe Alghoritm";
            // 
            // RecipeBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RecipeList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecipeBrowse";
            this.Text = "RecipeBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox RecipeList;
        private System.Windows.Forms.RichTextBox RecipeDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ProductName;
        private System.Windows.Forms.NumericUpDown ProductQuantity;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}