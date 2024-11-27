using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InfoSystemPtactika1
{
    public class SupplierInfo : Abstract
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string SupplierName { get; set; }
        public SupplierInfo(string supplierName, DateTime data, string name, int quantity)
        {
            SupplierName = supplierName;
            Date = data;
            Name = name;
            Quantity = quantity;
        }
        public override Abstract CreateFromString(string input)
        {
            string supplierString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] properties = supplierString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            return new SupplierInfo(properties[0].Trim('"'),
                DateTime.ParseExact(properties[1], "yyyy.MM.dd", null),
                properties[2].Trim('"'), int.Parse(properties[3]));
        }

        public override void PrintInfo()
        {
            Type metype = typeof(SupplierInfo);
            Console.WriteLine("Тип: " + metype.Name);
            Console.WriteLine("Поставщик: " + SupplierName);
            Console.WriteLine("Дата: " + Date.ToShortDateString());
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Количество: " + Quantity + "\n");
        }
    }
}
