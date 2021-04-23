using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using assignment_ek213_1604;

namespace Assignment_ek213_test
{
    [TestClass]
    public class UnitTest1
    {
        Supplier testClass;

        [TestMethod]
        public void TestMethod1()
        {
            testClass = new Supplier();
        }
        [TestMethod]
        public void testing()
        {
            Assert.IsNotNull(testClass);
        }
        [TestMethod]
        public void ItemsTest()
        {
            Items s = testClass.item[10];
            Assert.AreEqual(s.Price, 15m);
        }
    }
}
