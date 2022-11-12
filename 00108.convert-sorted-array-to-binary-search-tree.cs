// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public TreeNode SortedArrayToBST(int[] nums) => Rec(0, nums.Length - 1, nums);
    
    private static TreeNode Rec(int x, int y, int[] nums)
    {
        if (x > y) return null;
        int m = (x + y) / 2;
        TreeNode node = new TreeNode(nums[m]);
        node.left = Rec(x, m - 1, nums);
        node.right = Rec(m + 1, y, nums);
        return node;
    }
}
