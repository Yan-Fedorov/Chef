namespace ChiefKitchener.Forms
{
    partial class DailyDish
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
            this.QuantityOfPersons = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AllowedRecipeList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // QuantityOfPersons
            // 
            this.QuantityOfPersons.Location = new System.Drawing.Point(12, 25);
            this.QuantityOfPersons.Name = "QuantityOfPersons";
            this.QuantityOfPersons.Size = new System.Drawing.Size(79, 20);
            this.QuantityOfPersons.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity of persons";
            // 
            // AllowedRecipeList
            // 
            this.AllowedRecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowedRecipeList.FormattingEnabled = true;
            this.AllowedRecipeList.Location = new System.Drawing.Point(12, 50);
            this.AllowedRecipeList.Name = "AllowedRecipeList";
            this.AllowedRecipeList.Size = new System.Drawing.Size(360, 199);
            this.AllowedRecipeList.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(185, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "to form menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DailyDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllowedRecipeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantityOfPersons);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "DailyDish";
            this.Text = "DailyDish";
            this.Load += new System.EventHandler(this.DailyDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityOfPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown QuantityOfPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AllowedRecipeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}