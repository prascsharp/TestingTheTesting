using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCITests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            int result = new TestingCI.Calculator().Add(1,2);
            Assert.AreEqual(result, 3);
        }
    }
}
