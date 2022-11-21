// https://leetcode.com/problems/deepest-leaves-sum/description/
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
    public int DeepestLeavesSum(TreeNode root) 
    {
        Queue<(TreeNode Node, int Layer)> buffer = new ();
        buffer.Enqueue((root, 0));

        int currentLayer = 0;
        int result = 0;
        while (buffer.TryDequeue(out (TreeNode Node, int Layer) value))
        {
            if (value.Layer != currentLayer)
            {
                currentLayer = value.Layer;
                result = 0;
            }

            result += value.Node.val;

            int nextLayer = value.Layer + 1;
            if (value.Node.left is {} left) buffer.Enqueue((left, nextLayer));
            if (value.Node.right is {} right) buffer.Enqueue((right, nextLayer));
        }

        return result;
    }
}
