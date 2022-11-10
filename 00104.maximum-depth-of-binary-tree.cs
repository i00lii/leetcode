// https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
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
    public int MaxDepth(TreeNode root) 
    {
        Stack<(TreeNode, int)> buffer = new();
        buffer.Push((root, 1));

        int result = 0;
        while(buffer.TryPop(out (TreeNode Node, int Depth) value))
        {
            if (value.Node is {} node)
            {
                result = Math.Max(result, value.Depth);
                int depth = value.Depth + 1;

                buffer.Push((node.left, depth));
                buffer.Push((node.right, depth));
            }
        }

        return result;
    }
}
