using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace InfoSystemPtactika1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Елисей\\Documents\\GitHub\\Practika2\\InfoSystemPtactika1\\data.txt");
            List<Abstract> product = new List<Abstract>();
            ProductInfo productInfo = new ProductInfo(new DateTime(2000,01,01), "", 0);
            SupplierInfo supplierInfo = new SupplierInfo("", new DateTime(2000,01,01), "", 0);
            PurchaseHistory purchaseHistory = new PurchaseHistory(new DateTime(2000, 01, 01), "", 0, 0);
            foreach (string line in lines)
            {
                string[] lineCount = line.Split(';');
                string[] lineType = lineCount[0].ToString().Split(':');
                switch (lineType[0])
                {
                    case "ProductInfo":
                        {
                            product.Add(productInfo.CreateFromString(line));
                            break;
                        }
                    case "SupplierInfo":
                        {
                            product.Add(supplierInfo.CreateFromString(line));
                            break;
                        }
                    case "PurchaseHistory":
                        {
                            product.Add(purchaseHistory.CreateFromString(line));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого типа не существует");
                            break;
                        }
                }
            }

            foreach (var prod in product)
            {
                prod.PrintInfo();
            }
        }
    }
}
