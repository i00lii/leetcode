// https://leetcode.com/problems/merge-k-sorted-lists/description/
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
    private static readonly IComparer<ListNode> _comparer = new Comparer();
    private static readonly IComparer<ListNode> _nullComparer = new NullComparer();
    
    public ListNode MergeKLists(ListNode[] lists) 
    {
        ListNode fakeRoot = new ListNode();
        ListNode current = fakeRoot;
        
        int count = 0;
        Array.Sort(lists, _nullComparer);
        
        for(int idx = lists.Length - 1; idx >=0; idx--)
        {
            if (lists[idx] != default)
            {
                count = idx + 1;
                break;
            }
        }

        while (count > 1)
        {
            int lastIdx = count - 1;
            
            ListNode minValue = lists[lastIdx];
            current.next = minValue;
            current = current.next;

            if (minValue.next is {} next)
            {
                lists[lastIdx] = next;
                if (next.val > lists[lastIdx - 1].val)
                {
                    Array.Sort(lists, 0, count, _comparer);
                }
            }
            else
            {
                count--;
            }
        }
        
        if(count > 0)
            current.next = lists[0];

        return fakeRoot.next!;
    }
    
    private sealed class Comparer : IComparer<ListNode>
    {
        public int Compare(ListNode? x, ListNode? y) 
            => y.val - x.val; 
    }
    
    private sealed class NullComparer : IComparer<ListNode>
    {
        public int Compare(ListNode? x, ListNode? y) 
            => x == default && y == default ? 0
            : x == default ? 1
            : y == default ? -1
            : y.val - x.val;
    }
}
