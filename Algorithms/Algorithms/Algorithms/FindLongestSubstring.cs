using System;
using System.Collections.Generic;
namespace Algorithms.Algorithms
{
    /*
     Question : Find the longest substring in a given string
     I solved this problem with 2 solutions
      input = "abcabccdefg"; 
      output = 5 //cdefg
     */
    public static class LongestSubstring
    {
        //Time Complexity : o(n)
        //Space Complexity : o(1)
        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int[] cache = new int[256];
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                j = (cache[s[i]] > 0) ? Math.Max(j, cache[s[i]]) : j;
                cache[s[i]] = i + 1;
                result = Math.Max(result, i - j + 1);
            }
            return result;
        }
        public static int LengthOfLongestSubstring2(string s)
        {
            int result = 0;
            Dictionary<char, int> set = new Dictionary<char, int>();
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (set.ContainsKey(s[i])) { j = Math.Max(j, set[s[i]]); }
                set[s[i]] = i + 1;
                result = Math.Max(result, i - j + 1);
            }
            return result;
        }
    }
}
