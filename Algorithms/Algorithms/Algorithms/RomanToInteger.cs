using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
     */
    public static class RomanToInteger
    {
        //MMMCMXCIX => 3999
        public static int RomanToInt(string s)
        {
            int res = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var chr = s[i];
                switch (chr)
                {
                    case 'I':
                        res += (res >= 5 ? -1 : 1);
                        break;
                    case 'V':
                        res += 5;
                        break;
                    case 'X':
                        res += 10 * (res >= 50 ? -1 : 1);
                        break;
                    case 'L':
                        res += 50;
                        break;
                    case 'C':
                        res += 100 * (res >= 500 ? -1 : 1);
                        break;
                    case 'D':
                        res += 500;
                        break;
                    case 'M':
                        res += 1000;
                        break;
                }
            }
            return res;
        }
    }
}
