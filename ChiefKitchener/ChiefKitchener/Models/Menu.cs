using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiefKitchener.Models
{
    public class MenuItem
    {
        public Recipe Recipe { get; set; }
        public int QuantityOfPerson { get; set; }

        public IEnumerable<ProductInRecipe> RealProducts
        {
            get
            {
                foreach (var e in Recipe.Products)
                {
                    var nw = new ProductInRecipe
                    {
                        Name = e.Name,
                        Measure = e.Measure,
                        Price = e.Price,
                        Quantity = e.Quantity * QuantityOfPerson
                    };
                    yield return nw;
                }
            }
        }
        public override string ToString()
        {
            string res = string.Format("{0}| {1} persons|", Recipe.Name, QuantityOfPerson);
            bool comma = false;
            foreach (var product in Recipe.Products)
            {
                res += (comma ? ", " : "") + string.Format("{0}, {1}{2}", product.Name, product.Quantity * QuantityOfPerson, product.Measure);
                comma = true;
            }
            return res;
        }
    }
}
