using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystemPtactika1
{
    internal class Functions
    {
        public static void ProcessProduct(string input)
        {
            ProductInfo product = ProductInfo.CreateProductFromString(input);
            product.PrintInfo();
        }

        public static void ProcessSupplier(string input)
        {
            SupplierInfo supplier = SupplierInfo.CreateSupplierFromString(input);
            supplier.PrintInfo();
        }

        public static void ProcessPurchase(string input)
        {
            PurchaseHistory purchaseHistory = PurchaseHistory.CreatePurchaseHistoryFromString(input);
            purchaseHistory.PrintInfo();
        }
    }
}
