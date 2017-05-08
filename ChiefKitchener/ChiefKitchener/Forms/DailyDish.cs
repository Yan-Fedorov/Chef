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
    public partial class DailyDish : Form
    {
        List<Models.MenuItem> allowedRecipeList;
        public DailyDish()
        {
            InitializeComponent();
        }

        private void DailyDish_Load(object sender, EventArgs e)
        {

        }

        private void UpdateAllowedRecipeList()
        {
            AllowedRecipeList.Items.Clear();
            AllowedRecipeList.Items.AddRange(allowedRecipeList.Select(r => r.ToString()).ToArray()); // добавляем список рецептов на форму
        }
        private void button2_Click(object sender, EventArgs e) // check
        {
            int quantityOfPerson = (int)QuantityOfPersons.Value;
            if (quantityOfPerson <= 0) { MessageBox.Show("Quantity of people: " + quantityOfPerson); return; }
            var RecipeList = RecipeIOService.Open().ToList();
            allowedRecipeList = new List<Models.MenuItem>();
            foreach (var recipe in RecipeList)
            {
                var menuItem = new Models.MenuItem
                {
                    Recipe = recipe,
                    QuantityOfPerson = quantityOfPerson
                };

                try
                {
                    var result = MenuFormService.CheckProds(
                           new List<Models.MenuItem>() { menuItem }
                        );
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    continue;
                }
                allowedRecipeList.Add(menuItem);
            }
            UpdateAllowedRecipeList();
        }

        private void button1_Click(object sender, EventArgs e) // form meny
        {
            if (AllowedRecipeList.SelectedIndex > -1)
            {
                try
                {
                    MenuFormService.FormMenu(
                   new List<Models.MenuItem> {
                        allowedRecipeList[AllowedRecipeList.SelectedIndex]
                   });
                }catch(ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            button2_Click(new object(), new EventArgs());
        }
    }
}
