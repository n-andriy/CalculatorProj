using System;
using System.Collections.Generic;

namespace Calculator
{
    public static class MathCalcLibrary
    {
        /// <summary>
        /// Calculation mode property
        /// </summary>
        public static CalcMode calcMode { get; set; }

        /// <summary>
        /// Conversion to the Roman digits
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Roman equivalent</returns>
        public static string ConvertIntToRoman(int number)
        {
            if (number < 0) return "";

            // Dictionary definition of Arabic and Roman digits
            var romanNums = new Dictionary<int, string>
                                {
                                    {1000, "M"},
                                    {900, "CM"},
                                    {500, "D"},
                                    {400, "CD"},
                                    {100, "C"},
                                    {90, "XC"},
                                    {50, "L"},
                                    {40, "XL"},
                                    {10, "X"},
                                    {9, "IX"},
                                    {5, "V"},
                                    {4, "IV"},
                                    {1, "I"}
                                };

            var sRtn = "";
            var n = number;

            foreach (var pair in romanNums)
            {
                while (n >= pair.Key)
                {
                    n -= pair.Key;
                    sRtn += pair.Value;
                }
            }

            return sRtn;
        }

        /// <summary>
        /// Decimal to Binary converting
        /// </summary>
        /// <param name="number">Decimal representation of number</param>
        /// <returns>Binary representation of number</returns>
        public static string ConvertDecToBin(int number)
        {
            return Convert.ToString(number, 2);
        }

        /// <summary>
        /// Factorial calculation
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Factorial of number</returns>
        public static long Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number*Factorial(number - 1);
        }

        /// <summary>
        /// Sqrt calculation
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double GetSqrt(double number)
        {
            return Math.Sqrt(number);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static string Sum(string firstNumber, string secondNumber)
        {
            var calcResult = "";
            switch (calcMode)
            {
                case CalcMode.BinCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 2) + Convert.ToInt32(secondNumber, 2)), 2);
                    break;
                
                case CalcMode.DecCalculation:
                    calcResult = Convert.ToString(int.Parse(firstNumber) + int.Parse(secondNumber));
                    break;
                
                case CalcMode.HexCalculation:

                    break;
            }

            return calcResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Dividing 1/x
        /// </summary>
        /// <param name="number">Divider</param>
        /// <returns>Result of inverse dividing</returns>
        public static double InverseDivide(double number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException();
            }

            return 1 / number;
        }
    }

    public enum CalcMode
    {
        /// <summary>
        /// Hexadecimal
        /// </summary>
        HexCalculation,

        /// <summary>
        /// Decimal
        /// </summary>
        DecCalculation,

        /// <summary>
        /// Binary
        /// </summary>
        BinCalculation
    }
}
