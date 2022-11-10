// https://leetcode.com/problems/symmetric-tree/submissions/840732426/
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
    public bool IsSymmetric(TreeNode root)
    {
        Stack<(TreeNode, TreeNode)> buffer = new();
        buffer.Push((root.left, root.right));

        while (buffer.TryPop(out (TreeNode X, TreeNode Y) current))
        {
            if (current.X == default && current.Y == default)
                continue;

            if (current.X?.val != current.Y?.val)
                return false;

            buffer.Push((current.X.left, current.Y.right));
            buffer.Push((current.X.right, current.Y.left));
        }

        return true;
    }
}
