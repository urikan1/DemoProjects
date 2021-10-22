﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(33,Program.AddNumbers(3,40));
        }

        [TestMethod]
        public void SubstructTest()
        {
            Assert.AreEqual(12, Program.SubstructNumbers(50, 38));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(36, Program.MultiplyNumbers(4, 9));
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(2, Program.DivideNumbers(4, 2));
        }
    }
}
