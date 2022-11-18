// https://leetcode.com/problems/set-matrix-zeroes/description/
public class Solution 
{
    public void SetZeroes(int[][] matrix) 
    {
        int sizeX = matrix[0].Length;
        int sizeY = matrix.Length;

        bool clearX = false;
        bool clearY = false;

        for (int y = 0; y < sizeY; y++)
        {
            for (int x = 0; x < sizeX; x++)
            {
                if (matrix[y][x] != 0) continue;
                
                if (x == 0 || y == 0)
                {
                    if (x == 0) clearX = true;
                    if (y == 0) clearY = true;
                }
                else
                {    
                    matrix[0][x] = 0;
                    matrix[y][0] = 0;   
                }
            }
        }

        for (int x = 1; x < sizeX; x++)
        {
            if (matrix[0][x] == 0) ClearColumn(matrix, x);
        }

        for (int y = 1; y < sizeY; y++)
        {
            if (matrix[y][0] == 0) ClearRow(matrix, y);
        }

        if (clearX) ClearColumn(matrix, 0);
        if (clearY) ClearRow(matrix, 0);
    }

    private static void ClearRow(int[][] matrix, int y)
    {
         Array.Clear(matrix[y]);
    }

    private static void ClearColumn(int[][] matrix, int x)
    {
        foreach (int[] row in matrix) row[x] = 0;
    }
}
