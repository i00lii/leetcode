// https://leetcode.com/problems/intersection-of-two-linked-lists/description/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        ListNode t1 = headA;
        ListNode t2 = headB;

        while(t1 != t2)
        {
            t1 = t1 == null ? headB : t1.next;
            t2 = t2 == null ? headA : t2.next;
        }        

        return t1;
    }
}
