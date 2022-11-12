// https://leetcode.com/problems/path-sum/description/
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
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if (root == default)
            return false;

        Stack<(TreeNode, int)> buffer = new();
        buffer.Push((root, 0));

        while (buffer.TryPop(out (TreeNode Node, int CurrentValue) item))
        {
            int sum = item.Node.val + item.CurrentValue;
            bool hasChildren = false;

            if (item.Node.left is {} left)
            {
                hasChildren = true;
                buffer.Push((left, sum));
            }

            if (item.Node.right is {} right)
            {
                hasChildren = true;
                buffer.Push((right, sum));
            }

            if (!hasChildren && sum == targetSum)
            {
                return true;
            }
        }

        return false;
    }
}
