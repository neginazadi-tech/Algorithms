namespace Algorithms.Algorithms
{
    /*
     You are given the head of a linked list, and an integer k.
     Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end (the list is 1-indexed).

        Input: head = [1,2,3,4,5], k = 2
        Output: [1,4,3,2,5]

        Input: head = [7,9,6,6,7,8,3,0,9,5], k = 5
        Output: [7,9,6,6,8,7,3,0,9,5]
     */
    public class SwappingNodeInLinkedListSolution
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            //0 1 2 3 4 5    k= 2  => 1 4 3 2 5
            ListNode n1 = null, n2 = null;
            for (var p = head; p != null; p = p.next)
            {
                n2 = n2?.next;
                if (--k == 0)
                {
                    n1 = p;
                    n2 = head;
                }
            }
            var tmp = n1.val;
            n1.val = n2.val;
            n2.val = tmp;
            return head;
        }
    }
}
