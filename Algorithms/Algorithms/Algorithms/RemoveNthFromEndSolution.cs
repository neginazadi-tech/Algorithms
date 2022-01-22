using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms
{
    //Given the head of a linked list, remove the nth node from the end of the list and return its head.
    /*Input: head = [1,2,3,4,5], n = 2
    Output: [1,2,3,5]
    */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class RemoveNthFromEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            //0,1,2,3,4,5   n =3

            //0,1,2 n=2
            ListNode beforeNth = null;
            var start = new ListNode(0)
            {
                next = head
            };
            for (var p = start; p.next != null; p = p.next)
            {
                beforeNth = beforeNth?.next;
                if(--n == 0)
                {
                    beforeNth = start;
                }
            }
            beforeNth.next = beforeNth.next.next;
            return start.next;

            //ListNode start = new ListNode(0);
            //ListNode slow = start, fast = start;
            //slow.next = head;
            //for (int i = 1; i <= n + 1; i++)
            //{
            //    fast = fast.next;
            //}
            //while (fast != null)
            //{
            //    slow = slow.next;
            //    fast = fast.next;
            //}
            //slow.next = slow.next.next;
            //return start.next;
        }
    }
}
