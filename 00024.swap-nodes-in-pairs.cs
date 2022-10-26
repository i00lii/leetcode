// https://leetcode.com/problems/swap-nodes-in-pairs/description/// 
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
    public ListNode SwapPairs(ListNode head) 
    {
        if (head == default)
            return head;
        
        ListNode root = new ListNode(next: head);
        ListNode last = root;
    
        while(true)
        {
            ListNode x = last.next;
            
            if (x == default)
                break;
            
            ListNode y = x.next;
            
            if (y == default)
                break;
            
            ListNode z = y.next;
            
            y.next = x;
            x.next = z;
            
            last.next = y;
            last = x;
        }
        
        return root.next;
    }
}
