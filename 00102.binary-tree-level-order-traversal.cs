// https://leetcode.com/problems/binary-tree-level-order-traversal/description
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> buffer = new ();

        List<TreeNode> parentNodes = new ();
        List<TreeNode> childNodes = new ();

        if (root != default) parentNodes.Add(root);
            
        while (parentNodes.Count > 0)
        {
            List<int> values = new ();
            childNodes.Clear();
            
            foreach(TreeNode node in parentNodes)
            {
                values.Add(node.val);

                if (node.left is {} left) childNodes.Add(left);
                if (node.right is {} right) childNodes.Add(right);
            }

            buffer.Add(values);
            Swap(ref parentNodes, ref childNodes);
        }

        return buffer;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T t = x;
        x = y;
        y = t;
    }
}
