using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Algorithms
{
    /*
     Constraint : 1 <= n <= 8
 
     Input: n = 3
     Output: ["((()))","(()())","(())()","()(())","()()()"]

     Input: n = 1
     Output: ["()"]
     */
    public static class GenerateParenthesisSolution
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            List<String> list = new List<String>();
            backtrack(list, "", 0, 0, n);
            return list;
        }
        public static void backtrack(List<String> list, string str, int open, int close, int max)
        {
            if (str.Length == max * 2)
            {
                list.Add(str);
                return;
            }

            if (open < max)
                backtrack(list, str + "(", open + 1, close, max);
            if (close < open)
                backtrack(list, str + ")", open, close + 1, max);
        }
    }
}
