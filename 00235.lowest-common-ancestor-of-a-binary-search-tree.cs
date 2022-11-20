// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/description
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution 
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        (p, q) = p.val < q.val ? (p, q) : (q, p);
        
        int valueP = p.val;
        int valueQ = q.val;

        while (true)
        {
            int valueR = root.val;

            if (valueP > valueR)
            {
                root = root.right;
            }
            else if (valueQ < valueR)
            {
                root = root.left;
            }
            else
            {
                return root;
            }
        }
    }
}
