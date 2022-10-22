// https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/
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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        List<ListNode> buffer = new List<ListNode>(31);
        ListNode current = new ListNode(next: head);
        while (current != default)
        {
            buffer.Add(current);
            current = current.next;
        }
        
        int targetIdx = buffer.Count - n - 1;
        buffer[targetIdx++].next = buffer[targetIdx].next;
        return buffer[0].next;
    }
}
