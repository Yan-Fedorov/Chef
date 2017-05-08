using ChiefKitchener.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChiefKitchener.Services
{
    static class RecipeIOService
    {
        private static string fileName = "Recipes.txt";


        static public void Save(IEnumerable<Recipe> recipes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var recipe in recipes)
            {
                sb.AppendLine(recipe.Name);
                sb.AppendLine(recipe.RecipeAlgorithm);
                if (recipe.Products.Count > 0)
                {
                    sb.AppendLine(recipe.Products.Count.ToString());
                    foreach (var product in recipe.Products)
                    {
                        sb.AppendLine(product.Name);
                        sb.AppendLine(product.Price.ToString());
                        sb.AppendLine(product.Measure);
                        sb.AppendLine(product.Quantity.ToString());
                    }
                }
            }
            File.WriteAllText(fileName, sb.ToString(), Encoding.Unicode);
        }

        static public IEnumerable<Recipe> Open()
        {
            string[] source = File.ReadAllLines(fileName, Encoding.Unicode);
            List<Recipe> recipes = new List<Recipe>();
            for (int i = 0; i < source.Length;)
            {
                Recipe temp = new Recipe
                {
                    Name = source[i],
                    RecipeAlgorithm = source[i + 1],
                    Products = new List<ProductInRecipe>()
                };
                int countOfProd = int.Parse(source[i + 2]); // из строки в число
                i += 3;
                for (int j = 0; j <  countOfProd; j++)
                {
                    temp.Products.Add(new ProductInRecipe
                    {
                        Name = source[i + j * 4],
                        Price = double.Parse(source[i + j * 4 + 1]),
                        Measure = source[i + j * 4 + 2],
                        Quantity = double.Parse(source[i + j * 4 + 3])
                    });
                }
                i += countOfProd * 4;
                recipes.Add(temp);
            }
            return recipes;
        }
    }
}
