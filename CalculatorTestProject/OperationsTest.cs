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

        [TestMethod]
        public void ConvertDecToBin()
        {
            Assert.AreEqual("1101", MathCalcLibrary.ConvertDecToBin(13));
        }

        [TestMethod]
        public void FactorialCalc()
        {
            Assert.AreEqual(120, MathCalcLibrary.Factorial(5));
        }

        [TestMethod]
        public void SqrtCalc()
        {
            Assert.AreEqual(11, MathCalcLibrary.GetSqrt(121));
        }

        [TestMethod]
        public void InverseDivideCalc()
        {
            Assert.AreEqual(0.125, MathCalcLibrary.InverseDivide(8));
        }

        [TestMethod]
        public void BinSumCalc()
        {
            MathCalcLibrary.calcMode = CalcMode.BinCalculation;
            //Assert.AreEqual(1001, MathCalcLibrary.Sum(Convert, "0010"));
        }
    }
}
