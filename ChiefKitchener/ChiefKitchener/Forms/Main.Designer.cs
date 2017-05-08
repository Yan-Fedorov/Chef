namespace ChiefKitchener.Forms
{
    partial class Main
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
            this.Menu = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.RecipeList = new System.Windows.Forms.ComboBox();
            this.RecipeDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddRecipe = new System.Windows.Forms.Button();
            this.FormMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonQuantity = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.FormattingEnabled = true;
            this.Menu.ItemHeight = 25;
            this.Menu.Location = new System.Drawing.Point(18, 218);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(778, 129);
            this.Menu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.dailyDishToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(816, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recipeToolStripMenuItem
            // 
            this.recipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem});
            this.recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            this.recipeToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.recipeToolStripMenuItem.Text = "Recipe";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItemRecipeBrowse_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem1});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // browseToolStripMenuItem1
            // 
            this.browseToolStripMenuItem1.Name = "browseToolStripMenuItem1";
            this.browseToolStripMenuItem1.Size = new System.Drawing.Size(154, 30);
            this.browseToolStripMenuItem1.Text = "Browse";
            this.browseToolStripMenuItem1.Click += new System.EventHandler(this.browseToolStripMenuItemProductBrows_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem2});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // browseToolStripMenuItem2
            // 
            this.browseToolStripMenuItem2.Name = "browseToolStripMenuItem2";
            this.browseToolStripMenuItem2.Size = new System.Drawing.Size(154, 30);
            this.browseToolStripMenuItem2.Text = "Browse";
            this.browseToolStripMenuItem2.Click += new System.EventHandler(this.browseToolStripMenuItemInvoiceBrowse_Click);
            // 
            // dailyDishToolStripMenuItem
            // 
            this.dailyDishToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem3});
            this.dailyDishToolStripMenuItem.Name = "dailyDishToolStripMenuItem";
            this.dailyDishToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.dailyDishToolStripMenuItem.Text = "Daily dish";
            // 
            // browseToolStripMenuItem3
            // 
            this.browseToolStripMenuItem3.Name = "browseToolStripMenuItem3";
            this.browseToolStripMenuItem3.Size = new System.Drawing.Size(154, 30);
            this.browseToolStripMenuItem3.Text = "Browse";
            this.browseToolStripMenuItem3.Click += new System.EventHandler(this.browseToolStripMenuItemDailyDish_Click);
            // 
            // RecipeList
            // 
            this.RecipeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecipeList.FormattingEnabled = true;
            this.RecipeList.Location = new System.Drawing.Point(18, 45);
            this.RecipeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecipeList.Name = "RecipeList";
            this.RecipeList.Size = new System.Drawing.Size(544, 28);
            this.RecipeList.TabIndex = 2;
            this.RecipeList.SelectedIndexChanged += new System.EventHandler(this.RecipeList_SelectedIndexChanged);
            // 
            // RecipeDescription
            // 
            this.RecipeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeDescription.Location = new System.Drawing.Point(18, 86);
            this.RecipeDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecipeDescription.Name = "RecipeDescription";
            this.RecipeDescription.Size = new System.Drawing.Size(778, 69);
            this.RecipeDescription.TabIndex = 3;
            this.RecipeDescription.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(650, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete recipe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteButton);
            // 
            // AddRecipe
            // 
            this.AddRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecipe.Location = new System.Drawing.Point(528, 166);
            this.AddRecipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddRecipe.Name = "AddRecipe";
            this.AddRecipe.Size = new System.Drawing.Size(112, 35);
            this.AddRecipe.TabIndex = 4;
            this.AddRecipe.Text = "Add recipe";
            this.AddRecipe.UseVisualStyleBackColor = true;
            this.AddRecipe.Click += new System.EventHandler(this.AddRecipe_Click);
            // 
            // FormMenu
            // 
            this.FormMenu.Location = new System.Drawing.Point(18, 166);
            this.FormMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FormMenu.Name = "FormMenu";
            this.FormMenu.Size = new System.Drawing.Size(158, 35);
            this.FormMenu.TabIndex = 5;
            this.FormMenu.Text = "To form menu";
            this.FormMenu.UseVisualStyleBackColor = true;
            this.FormMenu.Click += new System.EventHandler(this.FormMenu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Person quantity";
            // 
            // PersonQuantity
            // 
            this.PersonQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonQuantity.Location = new System.Drawing.Point(316, 171);
            this.PersonQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PersonQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PersonQuantity.Name = "PersonQuantity";
            this.PersonQuantity.Size = new System.Drawing.Size(180, 26);
            this.PersonQuantity.TabIndex = 7;
            this.PersonQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 402);
            this.Controls.Add(this.PersonQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormMenu);
            this.Controls.Add(this.AddRecipe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RecipeDescription);
            this.Controls.Add(this.RecipeList);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(829, 431);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ComboBox RecipeList;
        private System.Windows.Forms.RichTextBox RecipeDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddRecipe;
        private System.Windows.Forms.Button FormMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PersonQuantity;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dailyDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem3;
    }
}

