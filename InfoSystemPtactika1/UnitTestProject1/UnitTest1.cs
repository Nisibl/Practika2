using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InfoSystemPtactika1;
using NUnit.Compatibility;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [NUnit.Framework.Test]
        public void CreateProductInfo_ValidInput_ReturnsProductInfo()
        {
            // Arrange
            string input = "ProductInfo:  2023.01.01  Хамстер  10";
            ProductInfo productInfo = new ProductInfo(new DateTime(2023,01,01), "Хамстер", 10);

            // Act
            ProductInfo result = productInfo.CreateFromString(input) as ProductInfo;

            // Assert

            ReferenceEquals(result, productInfo);

        }

        [NUnit.Framework.Test]
        public void CreatePurchaseHistory_ValidInput_ReturnsPurchaseHistory()
        {
            // Arrange
            string input = "ProductInfo:  2023.01.01  Хамстер  10  52";
            PurchaseHistory pur = new PurchaseHistory(new DateTime(2023,01,01), "Хамстер", 10, 52);

            // Act
            PurchaseHistory result = pur.CreateFromString(input) as PurchaseHistory;

            // Assert

            ReferenceEquals(result, pur);
        }

        [NUnit.Framework.Test]
        public void SupplierInfo_ValidInput_ReturnsSupplierInfo()
        {
            // Arrange
            string input = "Поставщик Геральт  2024.10.02  Тапки  101  ";
            SupplierInfo pur = new SupplierInfo("Поставщик Геральт", new DateTime(2024,10,02), "Тапки", 101);

            // Act
            SupplierInfo result = pur.CreateFromString(input) as SupplierInfo;

            // Assert

            ReferenceEquals(result, pur);
        }

        [NUnit.Framework.Test]
        public void CreateFromString_ProductInfo_InvalidDateFormat_ThrowsFormatException()
        {
            // Arrange
            string input = "ProductInfo:  2023.01.01rufhvuivgukr  Товар1  10";
            var productInfo = new ProductInfo(new DateTime(2023,01,01), "Товар1", 10);

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => productInfo.CreateFromString(input));
        }

        [NUnit.Framework.Test]
        public void CreateFromString_SupplierInfo_InvalidDateFormat_ThrowsFormatException()
        {
            // Arrange
            string input = "Поставщик Геральт  20fjkbgkbgs24.10.02  Тапки  101  ";
            var produc = new SupplierInfo("Поставщик Геральт", new DateTime(2024,10,02), "Тапки", 101);

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => produc.CreateFromString(input));
        }

        [NUnit.Framework.Test]
        public void CreateFromString_PurchaseHistory_InvalidDateFormat_ThrowsFormatException()
        {
            // Arrange
            string input = "2024.0гшуктцшимц1.10  Боты  5ро рио2  69  ";
            var produc = new PurchaseHistory(new DateTime(2024,01,01), "Боты", 52, 69);

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => produc.CreateFromString(input));
        }

    }
}
