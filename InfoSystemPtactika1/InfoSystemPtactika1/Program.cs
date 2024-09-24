using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InfoSystemPtactika1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string input = "Поступление товара:  2023.04.15  \"Футболка\"  10";

            ProductInfo product = ProductInfo.CreateProductFromString(input);
            
            product.PrintInfo();

            const string input2 = "Поставщик:  \"Поставщик Геральт\"  \"Город Красноярск, улица Семафорная, дом 189\"  89026494492";

            SupplierInfo supplier = SupplierInfo.CreateSupplierFromString(input2);

            supplier.PrintInfo();

            const string input3 = "Информация о покупке:  2023.04.01  \"Футболка\"  5  500";

            PurchaseHistory purchaseHistory = PurchaseHistory.CreatePurchaseHistoryFromString(input3);

            purchaseHistory.PrintInfo();
        }
    }
}
