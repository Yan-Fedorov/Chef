using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiefKitchener.Models
{
    public class Invoice
    {
        public List<FullProduct> Products { get; set; } // инкапсуляция 0.01
        public DateTime Date { get; set; }
        public Invoice() { }

        public Invoice(List<FullProduct> products, DateTime date)
        {
            Products = products;
            Date = date;
        }
        public override string ToString()
        {
            return string.Format("{0} | {1} {2}", Date.ToString(), Products.Count, Products.Count > 1 ? "items" : "item");
        }

    }
}
