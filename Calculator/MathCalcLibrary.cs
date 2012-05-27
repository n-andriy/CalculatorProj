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
        /// Sum calculation
        /// </summary>
        /// <param name="firstNumber">First operand</param>
        /// <param name="secondNumber">Second operand</param>
        /// <returns>Sum</returns>
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
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 16) + Convert.ToInt32(secondNumber, 16)), 16).ToUpper();
                    break;
            }

            return calcResult;
        }

        /// <summary>
        /// Substraction
        /// </summary>
        /// <param name="firstNumber">First operand</param>
        /// <param name="secondNumber">Second operand</param>
        /// <returns>Result of substraction</returns>
        public static string Substract(string firstNumber, string secondNumber)
        {
            var calcResult = "";
            switch (calcMode)
            {
                case CalcMode.BinCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 2) - Convert.ToInt32(secondNumber, 2)), 2);
                    break;

                case CalcMode.DecCalculation:
                    calcResult = Convert.ToString(int.Parse(firstNumber) - int.Parse(secondNumber));
                    break;

                case CalcMode.HexCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 16) - Convert.ToInt32(secondNumber, 16)), 16).ToUpper();
                    break;
            }
            
            return calcResult;
        }

        /// <summary>
        /// Dividing
        /// </summary>
        /// <param name="firstNumber">First operand</param>
        /// <param name="secondNumber">Second operand</param>
        /// <returns>Result of dividing</returns>
        public static string Dividing(string firstNumber, string secondNumber)
        {
            if (secondNumber == "0")
            {
                throw new DivideByZeroException();
            }

            var calcResult = "";
            switch (calcMode)
            {
                case CalcMode.BinCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 2) / Convert.ToInt32(secondNumber, 2)), 2);
                    break;

                case CalcMode.DecCalculation:
                    calcResult = Convert.ToString(double.Parse(firstNumber) / double.Parse(secondNumber));
                    break;

                case CalcMode.HexCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 16) / Convert.ToInt32(secondNumber, 16)), 16).ToUpper();
                    break;
            }

            return calcResult;
        }

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="firstNumber">First operand</param>
        /// <param name="secondNumber">Second operand</param>
        /// <returns>Result of multiplication</returns>
        public static string Multiplication(string firstNumber, string secondNumber)
        {
            var calcResult = "";
            switch (calcMode)
            {
                case CalcMode.BinCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 2) * Convert.ToInt32(secondNumber, 2)), 2);
                    break;

                case CalcMode.DecCalculation:
                    calcResult = Convert.ToString(int.Parse(firstNumber) * int.Parse(secondNumber));
                    break;

                case CalcMode.HexCalculation:
                    calcResult = Convert.ToString((Convert.ToInt32(firstNumber, 16) * Convert.ToInt32(secondNumber, 16)), 16).ToUpper();
                    break;
            }

            return calcResult;
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

        /// <summary>
        /// Converting result to hexadecimal (when appropriate radiobutton was checked)
        /// </summary>
        /// <param name="number">Value to convert</param>
        /// <returns>Converted value</returns>
        public static string ConvertValueToHex(string number)
        {
            return calcMode == CalcMode.DecCalculation ? int.Parse(number).ToString("X") : Convert.ToInt32(number, 2).ToString();
        }

        /// <summary>
        /// Converting result to decimal (when appropriate radiobutton was checked)
        /// </summary>
        /// <param name="number">Value to convert</param>
        /// <returns>Converted value</returns>
        public static string ConvertValueToDec(string number)
        {
            return calcMode == CalcMode.BinCalculation 
                       ? Convert.ToInt32(number, 2).ToString()
                       : Convert.ToInt32(number, 16).ToString().ToUpper();
        }

        /// <summary>
        /// Converting result to binary (when appropriate radiobutton was checked)
        /// </summary>
        /// <param name="number">Value to convert</param>
        /// <returns>Converted value</returns>
        public static string ConvertValueToBin(string number)
        {
            return calcMode == CalcMode.DecCalculation
                       ? Convert.ToString(int.Parse(number), 2)
                       : Convert.ToString(int.Parse(number), 2).ToUpper();

        }

        /// <summary>
        /// Remove a last symbol
        /// </summary>
        /// <param name="operand">Operand</param>
        /// <returns>Operand without last symbol</returns>
        public static string RemoveLastSymbol(string operand)
        {
            return operand.LastIndexOf(' ') == operand.Length - 1 ? "" : operand.Substring(0, operand.Length - 1);
        }
    }

    /// <summary>
    /// Number format
    /// </summary>
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
