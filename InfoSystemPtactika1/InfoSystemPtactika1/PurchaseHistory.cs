using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class PurchaseHistory : ProductInfo
    {
        public string Price { get; set; }

        public PurchaseHistory(string name, DateTime data, int quantity, string price) : base(name, data, quantity, DataType.PurchaseHistory)
        {
            Price = price;
        }

        public static PurchaseHistory CreatePurchaseHistoryFromString(string input)
        {
            string purchaseString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] properties = purchaseString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            return new PurchaseHistory(properties[1].Trim('"'),
                DateTime.ParseExact(properties[0], "yyyy.MM.dd", null),
                int.Parse(properties[2]),
                properties[3].Trim('"'));
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Сумма покупки: " + Price + " Рублей");
            base.PrintInfo();
        }
    }
}
