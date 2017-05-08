using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiefKitchener.Models
{
    public class ProductInRecipe : Product
    {
        private double quantity;
        public double Quantity // обертка для поля с маленькой
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value; // инкапсуляция
                }
            }
        }

        public ProductInRecipe() : base() { }

        public ProductInRecipe(string name, string measure, double price, double quantity) :
            base(name, measure, price)
        {
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0},{1} {2}", Name, Quantity, Measure);
        }
    }
}
