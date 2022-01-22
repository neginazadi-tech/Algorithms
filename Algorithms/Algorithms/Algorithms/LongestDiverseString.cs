using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace Algorithms.Algorithms
{
    /*
     A string s is called happy if it satisfies the following conditions:

        s only contains the letters 'a', 'b', and 'c'.
        s does not contain any of "aaa", "bbb", or "ccc" as a substring.
        s contains at most a occurrences of the letter 'a'.
        s contains at most b occurrences of the letter 'b'.
        s contains at most c occurrences of the letter 'c'.

        Input: a = 1, b = 1, c = 7
        Output: "ccaccbcc"
        Explanation: "ccbccacc" would also be a correct answer.
     */
    public static class LongestDiverseStringAlgorithm
    {
        static List<string> final = new List<string>();
        public static string LongestDiverseString(int a, int b, int c)
        {
            string str = "";//abccccccc  => 6!
            for (int i = 0; i < a; i++)
            {
                str += "a";
            }
            for (int i = 0; i < b; i++)
            {
                str += "b";
            }
            for (int i = 0; i < c; i++)
            {
                str += "c";
            }

            Permute(str, 0, str.Length - 1);

            var result = final.Distinct().ToList();
            return "";
        }


        private static bool CheckIsHappy(string happy)
        {
            if (happy.Contains("aaa") || happy.Contains("bbb") || happy.Contains("ccc")) return false;
            return true;
        }
      //jaygasht
       public static void Permute(string str, int start, int end)
        {
            if (start != end + 1)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    var res = Swap(str, start, i);
                    final.Add(res);
                }
                Permute(str, start + 1, end);
            }
        }

        private static string Swap(string str, int start, int i)
        {
            var toChar = str.ToCharArray();
            var temp = toChar[start];
            toChar[start] = toChar[i];
            toChar[i] = temp;
           
            var st = new string(toChar);
            return st;
        }
    }
}
