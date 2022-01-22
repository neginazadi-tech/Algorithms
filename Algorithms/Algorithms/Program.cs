using Algorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseNodesInkGroup group = new ReverseNodesInkGroup();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            //var head = new ListNode(1, new ListNode(2));
            group.ReverseKGroup(head, 2);

            SwappingNodeInLinkedListSolution node = new SwappingNodeInLinkedListSolution();
            // var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            //var head = new ListNode(1, new ListNode(2));
            //node.SwapNodes(head, 2);



            RemoveNthFromEndSolution n = new RemoveNthFromEndSolution();
            // var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
           // 
            n.RemoveNthFromEnd(head, 2);

           // GenerateParenthesisSolution.Test();
            //["dog","racecar","car"]
            //a , ab
            //
            // String str = "ABC";
            // int n = str.Length;
            //// LongestDiverseStringAlgorithm.Permute(str,0, n);
            // LongestDiverseStringAlgorithm.LongestDiverseString(1,1,7);
            // var m = new LetterCombinationsSolution();
            //var res =  m.LetterCombinations("234");
            //_3Sum.ThreeSumClosest(new int[] { -1, 2, 1, -4 },1);

            int i = 0;
            // trie.Insert("ca");
            // trie.Insert("cat");
            //// trie.Insert("cape");
            // trie.Insert("stop");
            // trie.Insert("start");

            // var gg = trie.AutoComplete("ca");

            // var a = trie.Search("cat");
            // var b = trie.Search("catss");
            // var n = trie.Search("ca");

            // var c = trie.StartWith("cat");
            // var d = trie.StartWith("pa");

            // RomanToInteger.RomanToInt("MMMCMXCIX");
            // IntegerToRoman.IntToRoman(3999);
            //{1, 8, 6, 2, 5, 4, 8, 3, 7} 49
            //{1,1} 1
            //[4,3,2,1,4]  16
            //{1,2,1}   2
            // var res = MaxAreaAlgorithm.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3 });

            //   ReversingInteger.Reverse(Int32.MaxValue);

            // ZigzagConversion.Convert("ABC", 2);
            ////1- Find Overlapping in a given array
            //var intervals = new int[3][];
            //intervals[0] = new int[2] { 1, 4 };
            //intervals[1] = new int[2] { 0, 2 };
            //intervals[2] = new int[2] { 3, 5 };
            //var res = Overlapping.Merge(intervals);

            ////2- Find Longest Substring
            //var longest1 = LongestSubstring.LengthOfLongestSubstring("abcabccdefg");
            //var longest2 = LongestSubstring.LengthOfLongestSubstring("abcabccdefg");

            ////3- You are given two non-empty linked lists representing two non-negative integers. 
            ////The digits are stored in reverse order, and each of their nodes contains a single digit. 
            ////Add the two numbers and return the sum as a linked list.
            //var l1 = new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9, null)))))));

            //var l2 = new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9,
            //    new Adding2LinkedList.ListNode(9, null))));

            //var finalLinkedList = Adding2LinkedList.AddTwoNumbers(l1, l2);

            ////4 - Finding longest Palindromic sub string
            //var longestStr = PalindromicSubstring.LongestPalindrome("cbbd");
            Console.ReadLine();
        }
    }
}
