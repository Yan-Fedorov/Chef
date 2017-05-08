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
    static class ProductIOService
    {
        private static string fileName = "Products.txt";


        static public void Save(IEnumerable<FullProduct> products) // создаю новый файл или перезаписываю список полученных продуктов
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine(product.Name);
                sb.AppendLine(product.Price.ToString());
                sb.AppendLine(product.Measure);
                sb.AppendLine(product.Quantity.ToString());
                sb.AppendLine(product.ExpDate.ToString());

            }
            File.WriteAllText(fileName, sb.ToString());
        }
        
        static public IEnumerable<FullProduct> Open()
        {
            string[] source = File.ReadAllLines(fileName); // считываем из файла строки по отдельности
            List<FullProduct> products = new List<FullProduct>();
            for (int i = 0; i < source.Length / 5; i++) 
            {
                products.Add(new FullProduct // записываем продукт из файла
                {
                    Name = source[i * 5],
                    Price = double.Parse(source[i * 5 + 1]),
                    Measure = source[i * 5 + 2],
                    Quantity = double.Parse(source[i * 5 + 3]),
                    ExpDate = DateTime.Parse(source[i * 5 + 4])
                });
            }
            return products;

        }
    }
}
