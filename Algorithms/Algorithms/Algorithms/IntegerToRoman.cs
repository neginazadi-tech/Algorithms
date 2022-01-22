using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms
{
    /*
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
Input: num = 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.
Input: num = 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         */
    public static class IntegerToRoman
    {
        //1 <= num <= 3999   MMMCMXCIX
        public static string IntToRoman(int num)
        {
            var I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };//1
            var X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };//10
            var C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };//100
            var M = new string[] { "", "M", "MM", "MMM" };//the coeficient of 1000
            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
        }
    }
}
