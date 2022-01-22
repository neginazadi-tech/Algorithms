using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms.Algorithms
{
    public static class StringToInteger
    {
        private static Regex digitOnly = new Regex(@"[\d]");
        public static int MyAtoi(string str)
        {
            if (str.Trim().Length <= 0 || str.Length > 200) 
                return 0; 
            
            int sign = 1, result = 0, i = 0;
            while (str[i] == ' ') { i++; }
            if (str[i] == '-')
            {
                sign = -1;
                i++;
            }
            else
                 if (str[i] == '+')
            {
                i++;
            }
            while (i < str.Length && digitOnly.IsMatch(str[i].ToString()))
            {
                if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && str[i] - '0' > 7))
                {
                    if (sign == 1) return Int32.MaxValue;
                    else return Int32.MinValue;
                }
                result = 10 * result + (str[i++] - '0');
            }
            return result * sign;
        }
    }
}
