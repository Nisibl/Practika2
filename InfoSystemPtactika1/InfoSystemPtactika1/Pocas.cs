using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class Pocas
    {
        public static void ProcessDataFromString()
        {
            const string inputProduct = "Поступление товара:  2023.04.15  \"Футболка\"  10";
            const string inputSupplier = "Поставщик:  \"Поставщик Геральт\"  \"Город Красноярск, улица Семафорная, дом 189\"  89026494492";
            const string inputPurchase = "Информация о покупке:  2023.04.01  \"Футболка\"  5  500";

            string[] stroki = { inputProduct, inputSupplier, inputPurchase };
            foreach (string stroka  in stroki)
            {
                if (stroka.Contains("Поступление товара:"))
                {
                    ProcessProduct(stroka);
                }
                else if (stroka.Contains("Поставщик:"))
                {
                    ProcessSupplier(stroka);
                }
                else if (stroka.Contains("Информация о покупке:"))
                {
                    ProcessPurchase(stroka);
                }
            }
        }

        private static void ProcessProduct(string input)
        {
            ProductInfo product = ProductInfo.CreateProductFromString(input);
            product.PrintInfo();
        }

        private static void ProcessSupplier(string input)
        {
            SupplierInfo supplier = SupplierInfo.CreateSupplierFromString(input);
            supplier.PrintInfo();
        }

        private static void ProcessPurchase(string input)
        {
            PurchaseHistory purchaseHistory = PurchaseHistory.CreatePurchaseHistoryFromString(input);
            purchaseHistory.PrintInfo();
        }
    }
}
