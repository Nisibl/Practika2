using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InfoSystemPtactika1;

namespace DopTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CountNull()
        {
            string str = "2023.01.01  Хамстер  10  52";
            int ex = 4;
            int gg = Null.CountNullInStr(str);

            Assert.AreEqual(ex, gg);
        }

        [TestMethod]
        public void Test_NullZeroInStr()
        {
            string str = "223.1.1  Хамстер  1  52";
            int ex = 0;
            int gg = Null.CountNullInStr(str);

            Assert.AreEqual(ex, gg);
        }

        [TestMethod]
        public void Test_NullInStr()
        {
            string str = "";

            var exep = Assert.ThrowsException<Exception>(() => Null.CountNullInStr(str));
            Assert.AreEqual("Пустая строка", exep.Message);
            
        }
    }
}
