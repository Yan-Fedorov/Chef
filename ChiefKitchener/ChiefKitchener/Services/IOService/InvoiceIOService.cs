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
    class InvoiceIOService
    {
        private static string fileName = "Invoices.txt";


        public static void Save(List<Invoice> invs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var inv in invs)
            {
                sb.AppendLine(inv.Date.ToString());
                if (inv.Products.Count() > 0)
                {
                    sb.AppendLine(inv.Products.Count().ToString());
                    foreach (var product in inv.Products)
                    {
                        sb.AppendLine(product.Name);
                        sb.AppendLine(product.Price.ToString());
                        sb.AppendLine(product.Measure);
                        sb.AppendLine(product.Quantity.ToString());
                        sb.AppendLine(product.ExpDate.ToString());
                    }
                }
            }
            File.WriteAllText(fileName, sb.ToString(), Encoding.Unicode);
        }

        public static void Add(Invoice inv)
        {
            List<Invoice> invs = Open();
            invs.Add(inv);
            Save(invs);
        }
        public static List<Invoice> Open()
        {
            string[] source = File.ReadAllLines(fileName, Encoding.Unicode); // считываем строки из файла инвойсов и добавляем их в строковый массив
            List<Invoice> invs = new List<Invoice>(); // создаем список инвойсов 
            for (int i = 0; i < source.Length;)
            {
                Invoice temp = new Invoice() // создаем инвойс, который будем добавлять в список накладных
                {
                    Date = DateTime.Parse(source[i]),
                    Products = new List<FullProduct>()
                };
                int countOfProd = int.Parse(source[i + 1]); // узнаем сколько продуктов
                i += 2; 
                for (int j = 0; j < countOfProd; j++) // j количество продуктов
                {
                    temp.Products.Add(new FullProduct
                    {
                        Name = source[i + j * 5],
                        Price = double.Parse(source[i + j * 5 + 1]),
                        Measure = source[i + j * 5 + 2],
                        Quantity = double.Parse(source[i + j * 5 + 3]),
                        ExpDate = DateTime.Parse(source[i + j * 5 + 4])
                    });
                }
                i += countOfProd * 5; // переходим на след инвойс
                invs.Add(temp); //добавляем только что считаный инвойс в список
            }
            return invs; 
        }
    }
}
