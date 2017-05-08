namespace ChiefKitchener.Forms
{
    partial class InvoiceBrowse
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
            this.InvoiceList = new System.Windows.Forms.ListBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvoiceList
            // 
            this.InvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceList.FormattingEnabled = true;
            this.InvoiceList.ItemHeight = 20;
            this.InvoiceList.Location = new System.Drawing.Point(0, 0);
            this.InvoiceList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InvoiceList.Name = "InvoiceList";
            this.InvoiceList.Size = new System.Drawing.Size(300, 514);
            this.InvoiceList.TabIndex = 0;
            this.InvoiceList.SelectedIndexChanged += new System.EventHandler(this.InvoiceList_SelectedIndexChanged);
            // 
            // ProductList
            // 
            this.ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 20;
            this.ProductList.Location = new System.Drawing.Point(0, 0);
            this.ProductList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(315, 514);
            this.ProductList.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InvoiceList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductList);
            this.splitContainer1.Size = new System.Drawing.Size(621, 514);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // InvoiceBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 514);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoiceBrowse";
            this.Text = "InvoiceBrowse";
            this.Load += new System.EventHandler(this.InvoiceBrowse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InvoiceList;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}