using ChiefKitchener.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiefKitchener.Services
{
    public static class MenuFormService
    {
        public static Tuple<IEnumerable<FullProduct>, List<FullProduct>> CheckProds(List<Models.MenuItem> menu) // Tuple can return several objects
        {
            if (menu == null || menu.Count == 0) throw new ArgumentNullException("Меню пустое!", new Exception());
            List<FullProduct> prods = ProductIOService.Open().ToList(); // продукты на складе
            var list = menu.SelectMany(m => m.RealProducts.Select(p => new { p.Name, p.Quantity }));
            // получаем из меню список названий продуктов и их количество 

            // есть список меню,у каждого меню есть список продуктов и для каждого элемента списка продуктов каждого меню мы выбираем только название и количество
            var invList = new List<FullProduct>();
            foreach (var el in list) // теперь этот список проходим циклом
            {
                if (prods.Any(p => p.Name == el.Name && p.Quantity >= el.Quantity)) // проверяем есть ли у нас товар из меню на складе 
                {

                    FullProduct source = prods.Where(p => p.Name == el.Name && p.Quantity >= el.Quantity).Min();
                    source.Quantity -= el.Quantity;
                    // отнимаем количество продуктов из склада 
                    var resProd = new FullProduct // создаем новый продукт из старого,копируя поля по значению
                    {
                        Measure = source.Measure,
                        Name = source.Name,
                        Price = source.Price,
                        Quantity = el.Quantity,
                        ExpDate = source.ExpDate
                    };

                    invList.Add(resProd); // добавляем скопированный продукт в список для накладной

                }
                else throw new ArgumentOutOfRangeException("На складе нет необходимого товара: " + el.Name, new Exception()); // выброс исклюения
            }
            // если все хорошо возвращаем кортеж двух списков
             return new Tuple<IEnumerable<FullProduct>, List<FullProduct>>(prods, invList);
           
        }

        public static void FormMenu(List<Models.MenuItem> menu)
        {
            var checkResult = CheckProds(menu);
            List<FullProduct> fp = checkResult.Item1.ToList();// Item1 - остаток на складе

            fp.RemoveAll(p => p.Quantity == 0); //убираем закончившиеся продукты со склада

            Invoice inv = new Invoice(checkResult.Item2, DateTime.Now.Date);
            InvoiceIOService.Add(inv); // добавит и сохранит инвойс
            ProductIOService.Save(fp);
            string message = checkResult.Item2.Aggregate("", (acc, b) => acc += b.ToString() + "\n"); // функция выполняющаяся для каждого продукта по очереди и агрегирующая список продуктов в строку
            message = string.Format("Menu is formed!\n\nInvoice Info: {0}\n\n{1}", inv.ToString(), message);
            MessageBox.Show(message);
        }
    }
}
