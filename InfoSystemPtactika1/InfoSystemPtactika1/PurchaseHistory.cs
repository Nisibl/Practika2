using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    /// <summary>Комментарий</summary>
    public class PurchaseHistory : Abstract
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public PurchaseHistory(DateTime data, string name, int quantity, int price)
        {
            Price = price;
            Date = data;
            Name = name;
            Quantity = quantity;
        }

        public override Abstract CreateFromString(string input)
        {
            string purchaseString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] properties = purchaseString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            return new PurchaseHistory(DateTime.ParseExact(properties[0], "yyyy.MM.dd", null), 
                properties[1].Trim('"'), int.Parse(properties[2]), int.Parse(properties[3]));
        }

        public override void PrintInfo()
        {
            Type metype = typeof(PurchaseHistory);
            Console.WriteLine("Тип: " + metype.Name);
            Console.WriteLine("Сумма покупки: " + Price + " Рублей");
            Console.WriteLine("Дата: " + Date.ToShortDateString());
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Количество: " + Quantity + "\n");
        }
    }
}
