using ChiefKitchener.Models;
using ChiefKitchener.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ChiefKitchener.Forms
{
    public partial class ProductBrowse : Form
    {
        List<FullProduct> products { get { return ProductIOService.Open().ToList(); } } // возвращает список из файла
        FullProduct currentProd = null;
        public ProductBrowse()
        {
            InitializeComponent();
        }

        bool isSimilarProds(FullProduct p)
        {
            return p.Name == ProductCombo.Text.Split('|')[0] &&
            p.Price == (double)ProductPrice.Value &&
            p.Measure == ProductMeasure.Text &&
            p.ExpDate.Date == ExpDate.Value.Date;
        }
        private void AddProduct(object sender, EventArgs e)
        {
            if (currentProd == null)
                currentProd = new FullProduct();
            if (!ValidateProd()) return;

            var prods = products;

            if (prods.Exists(isSimilarProds))
            {
                prods.First(isSimilarProds).Quantity += (double)ProductQuantity.Value;
            }
            else
            {
                currentProd = new FullProduct
                {
                    Name = ProductCombo.Text.Split('|')[0],
                    Measure = ProductMeasure.Text,
                    Price = (double)ProductPrice.Value,
                    Quantity = (double)ProductQuantity.Value,
                    ExpDate = ExpDate.Value
                };
                prods.Add(currentProd);
            }
            ProductIOService.Save(prods);
            UpdateProductList();
            UpdateProductCombo();
        }
        private bool ValidateProd()
        {
            List<string> errMess = new List<string>(4);
            string res = "";
            if (ProductPrice.Value == 0) errMess.Add("Price: 0.00");
            if (string.IsNullOrEmpty(ProductMeasure.Text.Trim())) errMess.Add("Measure: ???");
            if (ProductQuantity.Value == 0) errMess.Add("Quantity: 0.00");
            if (ExpDate.Value.Date <= DateTime.Now.Date) errMess.Add("Expiration date: Are you sure?");
            if (errMess.Count != 0)
            {
                MessageBox.Show(errMess.Aggregate(res, (ss, a) => ss + Environment.NewLine + a));
                return false;
            }
            return true;
        }

        private void UpdateProductList()
        {
            ProductList.Items.Clear();
            ProductList.Items.AddRange(products.Select(p => p.ToString()).ToArray());
        }
        private void UpdateProductCombo()
        {
            ProductCombo.Items.Clear();
            ProductCombo.Items.AddRange(products.Select(p => p.Name + "|" + p.Price).ToArray());
        }
        private void ProductBrowse_Load(object sender, EventArgs e)
        {
            UpdateProductCombo();
            UpdateProductList();
        }

        private void ProductCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prodInfo = ProductCombo.Text.Split('|');
            currentProd = products.First(p => p.Name == prodInfo[0] && p.Price == double.Parse(prodInfo[1]));
            ProductPrice.Value = (decimal)currentProd.Price;
            ProductMeasure.Text = currentProd.Measure;

        }
    }
}
