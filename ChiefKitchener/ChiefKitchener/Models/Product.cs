using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiefKitchener.Models
{
    abstract public class Product // объект класса создать нельзя,наследовать наследование
    {
        public string Name { get; set; }
        public string Measure { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name,string measure, double price)
        {
            Name = name;
            Measure = measure;
            Price = price;
        }
    }
}
