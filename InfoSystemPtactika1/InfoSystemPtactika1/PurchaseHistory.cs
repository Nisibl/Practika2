using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class PurchaseHistory
    {
        public DateTime PurchaseDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public static PurchaseHistory CreatePurchaseHistoryFromString(string input)
        {
            string purchaseString = input.Substring(input.IndexOf(":") + 1).Trim();

            string[] purchaseProperties = purchaseString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            PurchaseHistory purchaseHistory = new PurchaseHistory
            {
                PurchaseDate = DateTime.ParseExact(purchaseProperties[0], "yyyy.MM.dd", null),
                ProductName = purchaseProperties[1].Trim('"'),
                Quantity = int.Parse(purchaseProperties[2]),
                PurchasePrice = decimal.Parse(purchaseProperties[3])
            };

            return purchaseHistory;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Информация о покупке:");
            Console.WriteLine("Дата покупки: " + PurchaseDate);
            Console.WriteLine("Название товара: " + ProductName);
            Console.WriteLine("Количество: " + Quantity);
            Console.WriteLine("Цена покупки: " + PurchasePrice + " Рублей" + "\n");
        }
    }
}
