using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InfoSystemPtactika1;
using NUnit.Compatibility;
using System.IO;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [NUnit.Framework.Test]
        public void CompasionProductInfo()
        {
            DateTime Date = new DateTime(2023, 01, 01);
            string NameProduct = "Хамстер";
            int CountProducts = 10;
            ProductInfo productInfo = new ProductInfo(Date, NameProduct, CountProducts);
            ReferenceEquals(productInfo, "2023.01.01  Хамстер  10");
        }

        [NUnit.Framework.Test]
        public void ComparisonPurchaseHistory()
        {
            DateTime Date = new DateTime(2023, 01, 01);
            string NameProduct = "Хамстер";
            int CountProducts = 10;
            int SumPurchase = 52;
            PurchaseHistory purchaseHistory = new PurchaseHistory(Date, NameProduct, CountProducts, SumPurchase);
            ReferenceEquals(purchaseHistory, "2023.01.01  Хамстер  10  52");
        }

        [NUnit.Framework.Test]
        public void ComparisonSupplierInfo()
        {
            string NamePost = "Поставщик Геральт";
            DateTime Date = new DateTime(2024, 10, 02);
            string NameProduct = "Тапки";
            int Count = 101;
            SupplierInfo supplierInfo = new SupplierInfo(NamePost, Date, NameProduct, Count);
            ReferenceEquals(supplierInfo, "Поставщик Геральт  2024.10.02  Тапки  101");
        }

        [NUnit.Framework.Test]
        public void CreateConstructProductInfo()
        {
            DateTime date = new DateTime(2023, 01, 01);
            string nameproduct = "asd";
            string countproducts = "SA";

            Assert.ThrowsException<FormatException>(() =>
            {
                ProductInfo productInfo = new ProductInfo(date, nameproduct, Convert.ToInt32(countproducts));
            });
        }

        [NUnit.Framework.Test]
        public void CreateConstructPurchaseHistory()
        {
            DateTime Date = new DateTime(2023, 01, 01);
            string NameProduct = "Хамстер";
            int CountProducts = 10;
            string SumPurchase = "dsjfvnskjv";

            Assert.ThrowsException<FormatException>(() =>
            {
                PurchaseHistory purchaseHistory = new PurchaseHistory(Date, NameProduct, CountProducts, Convert.ToInt32(SumPurchase));
            });

        }

        [NUnit.Framework.Test]
        public void CreateConstructSupplierInfo()
        {
            string NamePost = "Поставщик Геральт";
            DateTime Date = new DateTime(2024, 10, 02);
            string NameProduct = "Тапки";
            string Count = "kjbnjbebrn43589";

            Assert.ThrowsException<FormatException>(() =>
            {
                SupplierInfo supplierInfo = new SupplierInfo(NamePost,Date,NameProduct,Convert.ToInt32(Count));
            });

        }

    }
}
