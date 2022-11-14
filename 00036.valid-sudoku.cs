// https://leetcode.com/problems/valid-sudoku/description/
public class Solution 
{
    private const int _boardSize = 9;
    private const int _squareSize = 3;

    public bool IsValidSudoku(char[][] board) 
    {
        int[] buffer = new int[_boardSize];
        
        for (int y = 0; y < _boardSize; y += _squareSize)
        {
            for (int x = 0; x < _boardSize; x += _squareSize)
            {
                if(!IsValidSquare(x, y, board, buffer))
                    return false;
            }
        }
        
        for (int y = 0; y < _boardSize; y++)
        {
            if (!IsValidRow(y, board, buffer))
                return false;
        }

        for (int x = 0; x < _boardSize; x++)
        {
            if (!IsvalidColumn(x, board, buffer))
                return false;
        }

        return true;
    }

    private static bool IsValidRow(int y, char[][] board, int[] buffer)
    {
        foreach(char current in board[y])
        {
            PushToBuffer(current, buffer);
        }

        return ValidateAndClearBuffer(buffer);
    }

    private static bool IsvalidColumn(int x, char[][] board, int[] buffer)
    {
        for (int y = 0; y < _boardSize; y++)
        {
            PushToBuffer(board[y][x], buffer);   
        }

        return ValidateAndClearBuffer(buffer);
    }

    private static bool IsValidSquare(int x, int y, char[][] board, int[] buffer)
    {
        for (int a = 0; a < _squareSize; a++)
        {
            for (int b = 0; b < _squareSize; b++)
            {
                PushToBuffer(board[y + b][x + a], buffer);
            }
        }

        return ValidateAndClearBuffer(buffer);
    }

    private static bool ValidateAndClearBuffer(int[] buffer)
    {
        bool isInvalid = false;
        foreach (int count in buffer)
        {
            if (count > 1)
            {
                isInvalid = true;
                break;   
            }
        }

        Array.Fill(buffer, 0);
        return !isInvalid;
    }

    private static void PushToBuffer(char currentChar, int[] buffer)
    {
        int current = currentChar - '1';
        if (current >= 0)
        {
            buffer[current]++;
        }
    }
}
