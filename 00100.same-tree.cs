// https://leetcode.com/problems/same-tree/description/
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
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        Stack<(TreeNode, TreeNode)> buffer = new();
        buffer.Push((p, q));

        while (buffer.TryPop(out (TreeNode x, TreeNode y) current))
        {
            if (current.x == default && current.y == default)
                continue;

            if (current.x == default || current.y == default || current.x.val != current.y.val)
                return false;

            buffer.Push((current.x.left, current.y.left));
            buffer.Push((current.x.right, current.y.right));
        }   

        return true;
    }
}
