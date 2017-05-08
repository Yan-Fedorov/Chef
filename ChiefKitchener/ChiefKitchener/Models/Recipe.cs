using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChiefKitchener.Models
{
    public class Recipe
    {
        public string Name { get; set; }

        public List<ProductInRecipe> Products { get; set; }

        public string RecipeAlgorithm { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // строит строку

            bool comma = false;
            foreach (var product in Products)
            {
                sb.Append((comma ? ", " : "") + string.Format("{0}, {1}{2}", product.Name, product.Quantity, product.Measure));
                comma = true;
            }

            sb.AppendLine(Environment.NewLine + RecipeAlgorithm);

            return sb.ToString();
        }
    }

}
