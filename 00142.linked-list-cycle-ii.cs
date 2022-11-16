// https://leetcode.com/problems/linked-list-cycle-ii/description
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    public ListNode DetectCycle(ListNode head) 
    {
        ListNode x = head;
        ListNode y = head;

        while (y?.next != default)
        {
            x = x.next;
            y = y.next.next;

            if (x == y)
            {
                y = head;
                while(x != y)
                {
                    x = x.next;
                    y = y.next;
                }

                return x;
            }
        }

        return default;
    }
}
