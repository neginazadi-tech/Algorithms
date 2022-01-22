using System;
namespace Algorithms.Algorithms
{
    public static class PalindromicSubstring
    {
        //cbbd => bb
        //babad => bab
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1) return s;
            int start = 0, end = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start+1)
                {
                    start = i - (len - 1) / 2;
                    end = i + (len / 2);
                }
            }
            return  s.Substring(start, end-start+1);
        }
        public static int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
