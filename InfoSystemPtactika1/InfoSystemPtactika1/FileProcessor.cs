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
                    Console.WriteLine("Строка из файла");
                    Functions.ProcessProduct(line);
                }
                else if (line.Contains("Поставщик:"))
                {
                    Console.WriteLine("Строка из файла");
                    Functions.ProcessSupplier(line);
                }
                else if (line.Contains("Информация о покупке:"))
                {
                    Console.WriteLine("Строка из файла");
                    Functions.ProcessPurchase(line);
                }
            }
        }
    }
}
