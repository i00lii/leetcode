// https://leetcode.com/problems/validate-binary-search-tree/description
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
    public bool IsValidBST(TreeNode root) 
        => Reccursion(root, long.MinValue, long.MaxValue);

    private static bool Reccursion(TreeNode node, long min, long max)
        => node == default ? true
        : node.val <= min || node.val >= max ? false
        : Reccursion(node.left, min, node.val) && Reccursion(node.right, node.val, max);
}
