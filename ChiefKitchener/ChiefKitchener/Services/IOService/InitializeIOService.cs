using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiefKitchener.Models;

namespace ChiefKitchener.Services
{
    public class InitializeIOService
    {
        public static List<Recipe> InitRecipe() // не нужен экземпляр класса для вызова метода - статический
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Name = "Potatoe&Tomatoes",
                    Products = InitProdInRec(),
                    RecipeAlgorithm = "Смешать все вместе"
                }

            };
        }
        public static List<ProductInRecipe> InitProdInRec() // создал список продуктов для рецептов
        {
            return new List<ProductInRecipe> { 
                new ProductInRecipe("Potatoes", "kg", 7.8,1),
            new ProductInRecipe("Tomatoes","kg", 55.66, 0.7)
          };
        }
        public static List<FullProduct> InitProd() // создал обычный список продуктов для склада
        {

            return new List<FullProduct> {
                new FullProduct("Potatoes", "kg", 7.8,1 , new DateTime(2017,9,27)),
            new FullProduct("Tomatoes","kg", 55.66, 0.7,new DateTime(2017,7,4))
          };
        }

        public static void InitializeAll()
        {
            ProductIOService.Save(InitProd()); // отправка списка на сохранение
            RecipeIOService.Save(InitRecipe());
        }
    }
}

