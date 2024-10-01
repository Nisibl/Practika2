using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class PurchaseHistory : ProductInfo
    {
        public decimal PurchasePrice { get; set; }
        public PurchaseHistory(string name, DateTime data, int quantity, decimal purchasePrice) : base(name, data, quantity)
        {
            Name = name;
            Date = data;
            Quantity = quantity;
            PurchasePrice = purchasePrice;
        }

        public static PurchaseHistory CreatePurchaseHistoryFromString(string input)
        {
            string purchaseString = input.Substring(input.IndexOf(":") + 1).Trim();

            string[] properties = purchaseString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            PurchaseHistory purchaseHistory = new PurchaseHistory(properties[1].Trim('"'),
                DateTime.ParseExact(properties[0], "yyyy.MM.dd", null),
                int.Parse(properties[2]), decimal.Parse(properties[3]));
           
            return purchaseHistory;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Информация о покупке:");
            Console.WriteLine("Дата покупки: " + Date);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Количество: " + Quantity);
            Console.WriteLine("Цена покупки: " + PurchasePrice + " Рублей" + "\n");
        }
    }
}
