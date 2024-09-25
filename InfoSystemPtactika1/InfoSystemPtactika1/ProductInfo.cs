using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class ProductInfo
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public static ProductInfo CreateProductFromString(string input) 
        {

            string propertiesString = input.Substring(input.IndexOf(":") + 1).Trim();

            string[] properties = propertiesString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            ProductInfo product = new ProductInfo
            {
                Date = DateTime.ParseExact(properties[0], "yyyy.MM.dd", null),
                Name = properties[1].Trim('"'),
                Quantity = int.Parse(properties[2])
            };

            return product;
        }
        public static void PrintInfo() 
        {
            Console.WriteLine("Поступление товаров:");
            Console.WriteLine("Дата: " + Date);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Количество: " + Quantity + "\n");
            
        }
    }
}
