using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class SupplierInfo
    {
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public long SupplierPhone { get; set; }

        public static SupplierInfo CreateSupplierFromString(string input)
        {
            string supplierString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] supplier = supplierString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            SupplierInfo supplierInfo = new SupplierInfo
            {
                SupplierName = supplier[0].Trim('"'),
                SupplierAddress = supplier[1].Trim('"')
            };

            if (long.TryParse(supplier[2], out long supplierPhone))
            {
                supplierInfo.SupplierPhone = supplierPhone;
            }
            else
            { 
                Console.WriteLine($"Не удалось преобразовать '{supplier[2]}' в числовое значение телефона.");
            }

            return supplierInfo;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Информация о поставщике:");
            Console.WriteLine("Наименование: " + SupplierName);
            Console.WriteLine("Адрес: " + SupplierAddress);
            Console.WriteLine("Телефон: " + SupplierPhone + "\n");
                
        }
    }
}
