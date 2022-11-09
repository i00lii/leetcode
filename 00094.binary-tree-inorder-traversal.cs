// https://leetcode.com/problems/binary-tree-inorder-traversal/description/
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
    public IList<int> InorderTraversal(TreeNode root) 
    {
        List<int> result = new();
        Reccursion(root);
        
        return result;

        void Reccursion(TreeNode node)
        {
            if (node == default)
                return;

            Reccursion(node.left);
            result.Add(node.val);
            Reccursion(node.right);
        }
    }
}
