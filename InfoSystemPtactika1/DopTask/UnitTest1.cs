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
            string str = "00010000100000";
            int ex = 5;
            int gg = Null.LongestZeroSequenceInStr(str);

            Assert.AreEqual(ex, gg);
        }

        [TestMethod]
        public void Test_NullZeroInStr()
        {
            string str = "111";
            int ex = 0;
            int gg = Null.LongestZeroSequenceInStr(str);

            Assert.AreEqual(ex, gg);
        }

        [TestMethod]
        public void Test_NullInStr()
        {
            string str = "";

            var exep = Assert.ThrowsException<Exception>(() => Null.LongestZeroSequenceInStr(str));
            Assert.AreEqual("Пустая строка", exep.Message);
            
        }
    }
}
