using ChiefKitchener.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChiefKitchener.Services;


namespace ChiefKitchener.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        IEnumerable<Recipe> recipe;
        
        Recipe currentRecipe = null;
        List<Models.MenuItem> MenuList = new List<Models.MenuItem>();
        private void Main_Load(object sender, EventArgs e)
        {
          //  InitializeIOService.InitializeAll();
            
            UpdateRecipeList();
        }
        private void UpdateRecipeList()
        {
            recipe = RecipeIOService.Open();
            RecipeList.Items.Clear();
            RecipeList.Items.AddRange(recipe.Select(p => p.Name).ToArray()); // из списка рецептов получаем список названий рецептов
        }
        private void RecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentRecipe = recipe.First(p => p.Name == RecipeList.Text);
            RecipeDescription.Text = currentRecipe.ToString();
        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {
            if (currentRecipe == null) { MessageBox.Show("Выберите рецепт!!!"); return; }
            if (MenuList.Any(p => p.Recipe.Name == currentRecipe.Name))
            {
                MenuList.First(p => p.Recipe.Name == currentRecipe.Name).QuantityOfPerson += (int)PersonQuantity.Value;
            }
            else
            {
                MenuList.Add(new Models.MenuItem
                {
                    QuantityOfPerson = (int)PersonQuantity.Value,
                    Recipe = currentRecipe
                });
            }
            UpdateMenuList();
        }

        private void UpdateMenuList() // отображаем список рецептов выбранных нами
        {
            Menu.Items.Clear();
            foreach (var el in MenuList)
            {
                Menu.Items.Add(el.ToString());
            }
        }
        private void DeleteButton(object sender, EventArgs e) //удаляем рецепт
        {
            if (Menu.SelectedIndex > -1)
            {
                Models.MenuItem toRemove = MenuList[Menu.SelectedIndex];
                MenuList.Remove(toRemove);
            }

            UpdateMenuList();
        }

        private void FormMenu_Click(object sender, EventArgs e)
        {
            try
            {
                MenuFormService.FormMenu(MenuList);
                MenuList.Clear();
                UpdateMenuList();
            }
            catch (ArgumentException ex)
            {
               MessageBox.Show(ex.Message);
            }
            
        }

        private void browseToolStripMenuItemRecipeBrowse_Click(object sender, EventArgs e)
        {
            new RecipeBrowse().ShowDialog();
            UpdateRecipeList();
        }

        private void browseToolStripMenuItemProductBrows_Click(object sender, EventArgs e)
        {
            new ProductBrowse().ShowDialog();
        }

        private void browseToolStripMenuItemInvoiceBrowse_Click(object sender, EventArgs e)
        {
            new InvoiceBrowse().ShowDialog();
        }

        private void browseToolStripMenuItemDailyDish_Click(object sender, EventArgs e)
        {
            new DailyDish().ShowDialog();
        }
    }
}
