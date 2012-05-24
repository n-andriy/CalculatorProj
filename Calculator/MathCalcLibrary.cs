using System.Collections.Generic;

namespace Calculator
{
    public static class MathCalcLibrary
    {
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

            string sRtn = "";
            int n = number;

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
    }
}
