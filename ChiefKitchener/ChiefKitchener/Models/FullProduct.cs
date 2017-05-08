using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChiefKitchener.Models
{
    public class FullProduct : Product, IComparable
    {
        public double Quantity { get; set; }

        public DateTime ExpDate { get; set; }

        public FullProduct() : base() { }

        public FullProduct(string name, string measure, double price, double quantity, DateTime expDate)
            : base(name, measure, price)
        {
            Quantity = quantity;
            ExpDate = expDate;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1}₴ | {2} {3} | To:{4}", Name, Price, Quantity, Measure, ExpDate.Date.ToShortDateString());
        }

        public int CompareTo(object obj)
        {
            FullProduct other = obj as FullProduct;
            if (other.Quantity > this.Quantity)
                return -1;
            else if (other.Quantity < this.Quantity)
                return 1;
            else
                return 0;
        }
    }
}
