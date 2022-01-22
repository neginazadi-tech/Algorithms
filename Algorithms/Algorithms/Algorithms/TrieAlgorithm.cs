using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Algorithms
{
    //Time complexity o(n) insert21`    Q123 search321Q `   aqw2e3456startWith
    //space : insert o(n)   other o(1)
    public class Node
    {
        public string Letter { get; set; }
        public Dictionary<char, Node> Children { get; set; }
        public bool IsWord;

        public Node(string letter)
        {
            Letter = letter;
            Children = new Dictionary<char, Node>();
        }
    }
    public class TrieAlgorithm
    {
        private readonly Node trie;
        public TrieAlgorithm(string[] dict)
        {
            trie = new Node("");
            foreach (string s in dict)
                InsertWord(s);
        }
        public string LongestCommonPerfix()
        {
            var current = trie;
            while(current.Children.Count > 0)
            {
                if (current.Children.Count > 1 || current.IsWord) return current.Letter;
                var c = Convert.ToChar(current.Children.FirstOrDefault().Key);
                current = current.Children[c];
            }
            return current.Letter;
        }
        private void InsertWord(string s)
        {
            Node curr = trie;
            if (s.Length == 0 && !curr.Children.ContainsKey(default))
            {
                curr.Children.Add(default, new Node(default));
                curr.IsWord = true;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!curr.Children.ContainsKey(s[i]))
                {
                    curr.Children.Add(s[i], new Node(s.Substring(0, i + 1)));
                }
                curr = curr.Children[s[i]];
                if (i == s.Length - 1)
                    curr.IsWord = true;
            }
        }
        public List<string> GetWordsForPrefix(string pre)
        {
            List<string> results = new List<string>();
            Node curr = trie;
            foreach (char c in pre.ToCharArray())
            {
                if (curr.Children.ContainsKey(c))
                {
                    curr = curr.Children[c];
                }
                else
                {
                    return results;
                }
            }
            FindAllChildWords(curr, results);
            return results;
        }
        private void FindAllChildWords(Node n, List<string> results)
        {
            if (n.IsWord)
                results.Add(n.Letter);
            foreach (var c in n.Children.Keys)
            {
                FindAllChildWords(n.Children[c], results);
            }
        }
    }

    public static class LongestCommon
    {
        //Input: strs = ["flower","flow","flight"]
        // Output: "fl"
        public static string LongestCommonPrefixWithTrie(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];

            var root = new TrieAlgorithm(strs);
           return  root.LongestCommonPerfix();
        }
        public static string LongestCommonPrefixWithBinarySearch(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            int minLen = Int32.MaxValue;
            foreach (var item in strs)
            {
                minLen = Math.Min(minLen, strs.Length);
            }

            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (IsCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);
        }
        private static bool IsCommonPrefix(String[] strs, int len)
        {
            string str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
        public static string LongestCommonPrefixWithDividAndConquer(string[] strs)
        {
            //Time = 2 T(n)/2 + o(m) = o(mn)   space = o(mlogn)
            if (strs.Length == 0) return "";
            return Common(strs, 0, strs.Length - 1);
        }
        private static string Common(string[] strs, int left, int right)
        {
            if (left == right) return strs[left];
            else
            {
                int mid = (left + right) / 2;
                var l = Common(strs, left, mid);
                var r = Common(strs, mid + 1, right);
                return CommonPrefix(l, r);
            }
        }
        private static string CommonPrefix(string l, string r)
        {
            int minLen = Math.Min(l.Length, r.Length);
            for (int i = 0; i < minLen; i++)
            {
                if (l[i] != r[i]) return l.Substring(0, i);

            }
            return l.Substring(0, minLen);
        }
        public static string LongestCommonPrefixWithVerticalScanning(string[] strs)
        {
            //o(n)   o(1)
            //f fl flo
            if (strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                var prefix = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != prefix)
                        return strs[0].Substring(0, i);
                }
            }

            return strs[0];
        }
        public static string LongestCommonPrefixWithHorizontalScanning(string[] strs)
        {
            //o(n)   o(1)
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            }
            return prefix;
        }
        public static string LongestCommonPrefixWithSorting(string[] strs)
        {
            int size = strs.Length;
            if (size == 0)
                return "";
            if (size == 1)
                return strs[0];
            Array.Sort(strs);
            int end = Math.Min(strs[0].Length, strs[size - 1].Length);
            int i = 0;

            while (i < end && strs[0][i] == strs[size - 1][i])
                i++;

            string pre = strs[0].Substring(0, i);
            return pre;
        }
    }
}

