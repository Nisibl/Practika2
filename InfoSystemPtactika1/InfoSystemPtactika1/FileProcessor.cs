using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InfoSystemPtactika1
{
    internal class FileProcessor
    {
        public static void ProcessDataFromFile(string filePath = "data.txt")
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line.Contains("Поступление товара:"))
                {
                    ProcessProduct(line);
                }
                else if (line.Contains("Поставщик:"))
                {
                    ProcessSupplier(line);
                }
                else if (line.Contains("Информация о покупке:"))
                {
                    ProcessPurchase(line);
                }
            }
        }

        private static void ProcessProduct(string input)
        {
            ProductInfo product = ProductInfo.CreateProductFromString(input);
            Console.WriteLine("Вывод информации из файла");
            product.PrintInfo();
        }

        private static void ProcessSupplier(string input)
        {
            SupplierInfo supplier = SupplierInfo.CreateSupplierFromString(input);
            Console.WriteLine("Вывод информации из файла");
            supplier.PrintInfo();
        }

        private static void ProcessPurchase(string input)
        {
            PurchaseHistory purchaseHistory = PurchaseHistory.CreatePurchaseHistoryFromString(input);
            Console.WriteLine("Вывод информации из файла");
            purchaseHistory.PrintInfo();
        }
    }
}
