// https://leetcode.com/problems/minimum-depth-of-binary-tree/description
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
    public int MinDepth(TreeNode root) 
    {
        if (root == default)
            return default;

        Stack<(TreeNode, int)> buffer = new();
        buffer.Push((root, 1));

        int result = int.MaxValue;
        while (buffer.TryPop(out (TreeNode Node, int Depth) value))
        {
            if (value.Node.left == default && value.Node.right == default)
            {
                result = Math.Min(result, value.Depth);
                continue;
            }
            
            if (value.Node.left is {} left)
            {
                buffer.Push((left, value.Depth + 1));
            }

            if (value.Node.right is {} right)
            {
                buffer.Push((right, value.Depth + 1));
            }
        }

        return result;
    }
}
