using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class SupplierInfo : ProductInfo
    {
        public string SupplierName { get; set; }

        public SupplierInfo(string name, DateTime data, int quantity, string supplierName) : base(name, data, quantity, DataType.SupplierInfo)
        {
            SupplierName = supplierName;
        }

        public static SupplierInfo CreateSupplierFromString(string input)
        {
            string supplierString = input.Substring(input.IndexOf(":") + 1).Trim();
            string[] properties = supplierString.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            return new SupplierInfo(properties[2].Trim('"'),
                DateTime.ParseExact(properties[1], "yyyy.MM.dd", null),
                int.Parse(properties[3]),
                properties[0].Trim('"'));
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Поставщик: " + SupplierName);
            base.PrintInfo();
        }
    }
}
