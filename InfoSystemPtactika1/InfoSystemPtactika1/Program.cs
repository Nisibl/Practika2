using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
enum DataType
{
    ProductInfo,
    SupplierInfo,
    PurchaseHistory
}

namespace InfoSystemPtactika1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductInfo> products = new List<ProductInfo>();
            List<SupplierInfo> suppliers = new List<SupplierInfo>();
            List<PurchaseHistory> purchases = new List<PurchaseHistory>();
            ProcessDataFromFile("C:\\Users\\Елисей\\Documents\\GitHub\\Practika2\\InfoSystemPtactika1\\data.txt", products, suppliers, purchases);

            Console.WriteLine("Информация о поступлении товаров:");
            foreach (var product in products)
            {
                product.PrintInfo();
            }

            Console.WriteLine("Информация о поставщиках:");
            foreach (var supplier in suppliers)
            {
                supplier.PrintInfo();
            }

            Console.WriteLine("Информация о покупках:");
            foreach (var purchase in purchases)
            {
                purchase.PrintInfo();
            }
        }

        public static void ProcessDataFromFile(string filePath = "data.txt",
            List<ProductInfo> products = null, List<SupplierInfo> suppliers = null, List<PurchaseHistory> purchases = null)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
                return;
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                if (line.Contains("ProductInfo:"))
                {
                    ProductInfo product = ProductInfo.CreateProductFromString(line, DataType.ProductInfo);
                    products.Add(product);
                }
                else if (line.Contains("SupplierInfo:"))
                {
                    SupplierInfo supplier = SupplierInfo.CreateSupplierFromString(line);
                    suppliers.Add(supplier);
                }
                else if (line.Contains("PurchaseHistory:"))
                {
                    PurchaseHistory purchaseHistory = PurchaseHistory.CreatePurchaseHistoryFromString(line);
                    purchases.Add(purchaseHistory);
                }
            }
        }
    }
}
