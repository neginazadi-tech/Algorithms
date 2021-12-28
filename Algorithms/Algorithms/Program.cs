using Algorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Find Overlapping in a given array
            var intervals = new int[3][];
            intervals[0] = new int[2] { 1, 4 };
            intervals[1] = new int[2] { 0, 2 };
            intervals[2] = new int[2] { 3, 5 };
            var res = Overlapping.Merge(intervals);

            //2- Find Longest Substring
            var longest1 = LongestSubstring.LengthOfLongestSubstring("abcabccdefg");
            var longest2 = LongestSubstring.LengthOfLongestSubstring("abcabccdefg");

            //3- You are given two non-empty linked lists representing two non-negative integers. 
            //The digits are stored in reverse order, and each of their nodes contains a single digit. 
            //Add the two numbers and return the sum as a linked list.
            var l1 = new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9, null)))))));

            var l2 = new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9,
                new Adding2LinkedList.ListNode(9, null))));

            var funalLinkedList = Adding2LinkedList.AddTwoNumbers(l1, l2);

            Console.ReadLine();
        }
    }
}
