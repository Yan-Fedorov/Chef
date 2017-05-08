using ChiefKitchener.Models;
using ChiefKitchener.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiefKitchener.Forms
{
    public partial class InvoiceBrowse : Form 
    {
        public InvoiceBrowse()
        {
            InitializeComponent();
        }
        List<Invoice> invoices { get { return InvoiceIOService.Open().ToList(); } }        
        private void InvoiceBrowse_Load(object sender, EventArgs e)
        {
            InvoiceList.Items.AddRange(invoices.Select(p => p.ToString()).ToArray());
        }

        private void InvoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductList.Items.Clear();
            ProductList.Items.AddRange(
                invoices[InvoiceList.SelectedIndex].
                Products.Select(p=>p.ToString()).ToArray());
        }
    }
}
