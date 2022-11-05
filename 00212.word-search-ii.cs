// https://leetcode.com/problems/word-search-ii/description/
public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words) => DfsEveryNode(board, BuildWordsTree(words));

    private static List<string> DfsEveryNode(char[][] board, Trie trie)
    {
        List<string> result = new List<string>();

        int sizeX = board[0].Length;
        int sizeY = board.Length;

        result = new List<string>();

        for (int y = 0; y < sizeY; y++)
        {
            for (int x = 0; x < sizeX; x++)
            {
                HashSet<(int, int)> visitedNodes = new HashSet<(int, int)>();

                foreach (Trie? node in trie.Children)
                {
                    if (node != default)
                    {
                        Reccursion(node, x, y, visitedNodes);
                    }
                }
            }
        }

        return result;

        void Reccursion(Trie trie, int x, int y, HashSet<(int, int)> visitedNodes)
        {
            if (board[y][x] != trie.Current || visitedNodes.Contains((x, y)))
                return;

            if (trie.Value != default)
            {
                result.Add(trie.Value);
                trie.Value = default;
            }

            visitedNodes.Add((x, y));

            foreach (Trie? node in trie.Children)
            {
                if (node != default)
                {
                    if (x + 1 < sizeX)
                        AppendRecursive(node, x + 1, y, visitedNodes);

                    if (x - 1 >= 0)
                        AppendRecursive(node, x - 1, y, visitedNodes);

                    if (y + 1 < sizeY)
                        AppendRecursive(node, x, y + 1, visitedNodes);

                    if (y - 1 >= 0)
                        AppendRecursive(node, x, y - 1, visitedNodes);
                }
            }

            visitedNodes.Remove((x, y));
        }
    }

    private static Trie BuildWordsTree(string[] words)
    {
        Trie root = new Trie(default, new Trie[26]);
        Trie node = root;

        foreach (string word in words)
        {
            foreach (char current in word)
            {
                node = node.Children[current - 'a'] is { } child ? child : node.Children[current - 'a'] = new Trie(current, new Trie[26]);
            }

            node.Value = word;
            node = root;
        }

        return root;
    }

    private sealed record Trie(char Current, Trie?[] Children)
    {
        public string? Value { get; set; }
    }
}

