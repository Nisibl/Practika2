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
    internal class ProductInfo
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DataType Type { get; set; }
        public ProductInfo(string name, DateTime data, int quantity, DataType type)
        {
            Name = name;
            Date = data;
            Quantity = quantity;
            Type = type;
        }
        public static ProductInfo CreateProductFromString(string input, DataType type)
        {
            string propertiesString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] properties = propertiesString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            return new ProductInfo(properties[1].Trim('"'),
                DateTime.ParseExact(properties[0], "yyyy.MM.dd", null),
                int.Parse(properties[2]),
                type);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Дата: " + Date);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Количество: " + Quantity + "\n");
        }
    }
}
