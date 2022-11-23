// https://leetcode.com/problems/word-search/description/
public class Solution 
{
    private static (int, int)[] _shifts = new (int, int)[]
    {
        (0, 1),
        (1, 0),
        (0, -1),
        (-1, 0)
    };

    public bool Exist(char[][] board, string word) 
    {
        int sizeX = board[0].Length;
        int sizeY = board.Length;

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                char head = board[y][x];

                if (TryFindWord(x, y, 0))
                {
                    return true;
                }
            }
        }

        return false;

        bool TryFindWord(int x, int y, int wordOffset)
        {
            if (x < 0 || x >= sizeX || y < 0 || y >= sizeY) return false; 

            const char stub = '_';
            ref char boardValue = ref board[y][x];
            char wordValue = word[wordOffset];

            if (boardValue != wordValue) return false;
            if (wordOffset == word.Length - 1) return true;

            boardValue = stub;

            foreach((int deltaX, int deltaY) in _shifts)
            {
                if (TryFindWord(x + deltaX, y + deltaY, wordOffset + 1)) return true;
            }

            boardValue = wordValue;
            return false;
        }
    } 
}
