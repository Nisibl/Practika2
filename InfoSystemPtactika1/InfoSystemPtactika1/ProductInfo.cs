using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class ProductInfo : Abstract
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public ProductInfo(DateTime data, string name, int quantity)
        {
            Name = name;
            Date = data;
            Quantity = quantity;
        }
        public override Abstract CreateFromString(string input)
        {
            string propertiesString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] properties = propertiesString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            return new ProductInfo(DateTime.ParseExact(properties[0], "yyyy.MM.dd", null),
                properties[1].Trim('"'), int.Parse(properties[2]));
        }
        public override void PrintInfo()
        {
            Type metype = typeof(ProductInfo);
            Console.WriteLine("Тип: " + metype.Name);
            Console.WriteLine("Дата: " + Date);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Количество: " + Quantity + "\n");
        }
    }
}
