// https://leetcode.com/problems/middle-of-the-linked-list/description
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode l = head;
        ListNode r = head;

        while (r?.next != default)
        {
            l = l.next;
            r = r.next.next;
        }

        return l;
    }
}