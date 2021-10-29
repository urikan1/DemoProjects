using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCalc;

namespace TestCalc
{
    [TestClass]
    public class BasicOpTests
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(43,Program.AddNumbers(3,40));
        }

        [TestMethod]
        public void SubstructTest()
        {
            Assert.AreEqual(12, Program.SubstructNumbers(50, 38));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(32, Program.MultiplyNumbers(4, 8));
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(3, Program.DivideNumbers(4, 2));
        }
    }
}
