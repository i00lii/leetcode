// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/description/
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
        ListNode fakeHead = new ListNode(next: head);
        head = fakeHead;
        
        ListNode x = head;
        ListNode y = x?.next;
        ListNode z = y?.next;
        
        while(y != default && z != default)
        {
            if (y.val != z.val)
            {
                x = y;
                y = z;
                z = z?.next;
            }
            else 
            {
                while (z != default && y.val == z.val)
                {
                    ListNode nextAfterZ = z.next;
                    
                    y.next = nextAfterZ;
                    z = nextAfterZ;
                }
                
                x.next = z;
                y = z;
                z = z?.next;
            }
        }
        
        return fakeHead.next;
    }
}
