// https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if (head == default)
            return head;
        
        ListNode originalHead = head;
        
        while (head.next is {} next)
        {
            if (head.val == next.val)
            {
                head.next = next.next;
            }
            else 
            {
                head = head.next;
            }            
        }
        
        return originalHead;
    }
}
