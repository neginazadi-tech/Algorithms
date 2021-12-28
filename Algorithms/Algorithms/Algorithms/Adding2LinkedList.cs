namespace Algorithms.Algorithms
{
    /*
        Input: l1 = [2,4,3], l2 = [5,6,4] => they are linked List
        Output: [7,0,8]
        Explanation: 342 + 465 = 807.
     */
    public static class Adding2LinkedList
    {
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
        //Solution : We have to sum coresponding value in 2 linked list.
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0), current = result; int leftover = 0;
            while (l1 != null || l2 != null)
            {
                if (l1 == null) l1 = new ListNode(0);
                if (l2 == null) l2 = new ListNode(0);

                int sum = leftover + l1.val + l2.val;
                int mod = sum % 10;
                leftover = sum / 10;
                current.next = new ListNode(mod);
                current = current.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            if (leftover > 0) current.next = new ListNode(leftover);
            return result.next;
        }
    }
}
