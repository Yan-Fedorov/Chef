using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiefKitchener.Models;
using ChiefKitchener.Services;

namespace ChiefKitchener.Forms
{
    public partial class RecipeBrowse : Form
    {
        List<Recipe> recipes { get { return RecipeIOService.Open().ToList(); } }
        Recipe currentRecipe = null;
        List<FullProduct> allProds { get { return ProductIOService.Open().ToList(); } }
        public RecipeBrowse()
        {
            InitializeComponent();
            UpdateRecipeList();
            UpdateProductList();
        }

        private void UpdateRecipeList()
        {
            RecipeList.Items.Clear();
            foreach (var recipe in recipes)
            {
                RecipeList.Items.Add(recipe.Name);
            }
        }

        private void UpdateProductInRecipeList()
        {
            ProductList.Items.Clear();

            ProductList.Items.AddRange(currentRecipe.Products.Select(p => p.ToString()).ToArray());
        }

        private void UpdateProductList()
        {
            ProductName.Items.Clear();
            ProductName.Items.AddRange(allProds.Select(p => p.Name).Distinct().ToArray());
        }
        
        private void RecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentRecipe = recipes.First(r => r.Name == RecipeList.Text);
            RecipeDescription.Text = currentRecipe.RecipeAlgorithm;
            UpdateProductInRecipeList();
        }

        private void SaveRecipe(object sender, EventArgs e)
        {
            if (currentRecipe == null)
                currentRecipe = new Recipe();

            if (string.IsNullOrWhiteSpace(RecipeList.Text))
            {
                MessageBox.Show("Нечего сохранять!");
                return;
            }
            if (currentRecipe.Products == null || currentRecipe.Products.Count == 0) { MessageBox.Show("Добавьте товаров!"); return; }
            var recs = recipes;
            if (recipes.Exists(r => r.Name == RecipeList.Text))
            {
                var rec = recs.First(r => r.Name == RecipeList.Text);
                List<char> l = RecipeDescription.Text.ToList();
                l.RemoveAll(m => m == '\n');
                string res = "";
                rec.RecipeAlgorithm = l.Aggregate(res, (acc, b) => acc += b);
                rec.Products = currentRecipe.Products;

            }
            else
            {
                currentRecipe.Name = RecipeList.Text;
                recs.Add(currentRecipe);
            }
            RecipeIOService.Save(recs);
            UpdateRecipeList();

        }

        private void AddProductInRecipe(object sender, EventArgs e)
        {
            if (ProductName.SelectedIndex < 0|| ProductQuantity.Value == 0) return;
            if (currentRecipe == null) currentRecipe = new Recipe();
            if (currentRecipe.Products == null)
                currentRecipe.Products = new List<ProductInRecipe>();

            if (currentRecipe.Products.Any(z => z.Name == ProductName.Text))
                currentRecipe.Products.First(z => z.Name == ProductName.Text).Quantity += (double)ProductQuantity.Value;
            else
            {
                Product p = allProds.First(f => f.Name == ProductName.Text);
                currentRecipe.Products.Add(new ProductInRecipe
                {
                    Name = p.Name,
                    Measure = p.Measure,
                    Price = p.Price,
                    Quantity = (double)ProductQuantity.Value
                });
            }
            UpdateProductInRecipeList();
        }

        private void DeleteProductFromRecipe(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex > -1)
                currentRecipe.Products.RemoveAt(ProductList.SelectedIndex);
            UpdateProductInRecipeList();
        }

        private void DeleteRecipe(object sender, EventArgs e)
        {
            if (RecipeList.SelectedIndex == -1) return;
            var recs = recipes;
            recs.RemoveAt(RecipeList.SelectedIndex);
            RecipeIOService.Save(recs);
            UpdateRecipeList();
            currentRecipe = new Recipe();
            currentRecipe.Products = new List<ProductInRecipe>();
            RecipeList.Text = "";
            UpdateProductInRecipeList();
        }
    }
}
