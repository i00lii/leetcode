// https://leetcode.com/problems/n-ary-tree-preorder-traversal/description
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution 
{
    public IList<int> Preorder(Node root) 
    {
        List<int> buffer = new();
        PreorderReccursive(root, buffer);

        return buffer;
    }

    private static void PreorderReccursive(Node node, List<int> buffer)
    {
        if (node != default)
        {
            buffer.Add(node.val);
        }

        foreach (Node child in node?.children ?? Enumerable.Empty<Node>())
        {
            PreorderReccursive(child, buffer);
        }
    }
}
