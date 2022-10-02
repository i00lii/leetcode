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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode resultHead = default;
        ListNode resultTail = default;
        int overflow = default;
        
        while(l1 != default || l2 != default)
        {
            int sum = (l1?.val ?? default) + (l2?.val ?? default) + overflow;
            
            overflow = sum / 10;
            ListNode newNode = new ListNode(sum % 10);
            
            if (resultHead == default)
            {
                resultHead = newNode;
                resultTail = newNode;  
            }
            else
            {
                resultTail.next = newNode;
                resultTail = newNode;
            }
            
            l1 = l1?.next;
            l2 = l2?.next;
        }
        
        if (overflow != default)
        {
            resultTail.next = new ListNode(overflow);
        }
        
        return resultHead;
    }
}


































































