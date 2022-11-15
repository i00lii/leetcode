//
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
    public int CountNodes(TreeNode root)
    {
        int l = Count(root, x => x.left);
        int r = Count(root, x => x.right);
        return l == r ? (int)Math.Pow(2, l) - 1 : 1 + CountNodes(root.left) + CountNodes(root.right); 
    }

    private static int Count(TreeNode root, Func<TreeNode, TreeNode> next)
    {
        int count = 0;
        while (root != default)
        {
            count++;
            root = next(root);
        }

        return count;
    }   
}
