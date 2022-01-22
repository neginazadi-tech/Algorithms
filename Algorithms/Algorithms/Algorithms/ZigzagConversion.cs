using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms
{
    public static class ZigzagConversion
    {
        /*
        Input: s = "PAYPALISHIRING", numRows = 4
        Output: "PINALSIGYAHRPI"
        Explanation:
        P     I    N =>   
        A   L S  I G
        Y A   H R
        P     I

            =>
            P I N
            ALSIG
            YAHR
            P I
         */
        public static string Convert(string s, int numRows)
        {
            int index = 0;
            StringBuilder[] st = new StringBuilder[numRows];
            for (int i = 0; i < st.Length; i++) st[i] = new StringBuilder();
            while (index < s.Length)
            {
                for (int i = 0; i < numRows && index < s.Length; i++) st[i].Append(s[index++]);
                for (int i = numRows - 2; i > 0 && index < s.Length; i--) st[i].Append(s[index++]);
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < st.Length; i++) result.Append(st[i]);
            return result.ToString();
        }
    }
}
