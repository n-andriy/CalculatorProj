using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestProject
{
    [TestClass]
    public class OperationsTest
    {
        [TestMethod]
        public void ConvertIntToRomanNumTest()
        {
            Assert.AreEqual("XI", MathCalcLibrary.ConvertIntToRoman(11));
        }

        [TestMethod]
        public void ConvertIntToRomanZeroTest()
        {
            Assert.AreEqual("", MathCalcLibrary.ConvertIntToRoman(0));
        }
    }
}
