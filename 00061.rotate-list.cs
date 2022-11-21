// https://leetcode.com/problems/rotate-list/description/
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
    public ListNode RotateRight(ListNode head, int k) 
    {
        int count = Count(head);
        if (count == 0 || (k = k % count) == 0) return head; 

        ListNode newTail = Skip(head, count - k - 1);
        ListNode newHead = newTail.next;
        
        Skip(newTail, k).next = head;
        newTail.next = null;
        
        return newHead;
    }

    private static ListNode Skip(ListNode node, int count)
    {
        while (count-- > 0)
        {
            node = node.next;
        }
        return node;
    }

    private static int Count(ListNode node)
    {
        int count = 0;
        while (node != default)
        {
            node = node.next;
            count++;
        }
        return count;
    }
}
