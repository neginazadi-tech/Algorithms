using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms
{
   public class ReverseNodesInkGroup
    {
        /*
        Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.
        k is a positive integer and is less than or equal to the length of the linked list. 
        If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
        You may not alter the values in the list's nodes, only nodes themselves may be changed.

            Input: head = [1,2,3,4,5], k = 2
            Output: [2,1,4,3,5]
         */
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int counter = k; Stack<ListNode> stack = new Stack<ListNode>();
            var first = new ListNode();first = head;
            for (var p = head; p != null; p = p.next)
            {
                if (counter-- == 0)
                {
                    var t = stack.Pop();
                    while (stack.Count > 0)
                    {
                        var item = stack.Pop();
                        var temp = first.next;
                        t.next = item;
                        item.next = temp;

                        t = item;
                    }
                    counter = k-1;
                }
                stack.Push(p);
            }


            return first;
        }
    }
}
