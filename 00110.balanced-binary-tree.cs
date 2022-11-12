// https://leetcode.com/problems/balanced-binary-tree/description/
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
    public bool IsBalanced(TreeNode root) => IsBalanced(root, 0).Item2;
    
    private static (int, bool) IsBalanced(TreeNode node, int depth)
    {
        if (node == default) return (0, true);
        (int lDepth, bool lBalanced) = IsBalanced(node.left, depth);
        (int rDepth, bool rBalanced) = IsBalanced(node.right, depth);
        return (1 + Math.Max(lDepth, rDepth), lBalanced && rBalanced && Math.Abs(lDepth - rDepth) < 2);
    }
}
