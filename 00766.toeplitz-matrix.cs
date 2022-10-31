// https://leetcode.com/problems/toeplitz-matrix/description
public class Solution 
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        int x = matrix[0].Length;
        int y = matrix.Length;

        for (int yIdx = 1; yIdx < y; yIdx++)
        {
            int[] a = matrix[yIdx - 1];
            int[] b = matrix[yIdx];

            for (int xIdx = 1; xIdx < x; xIdx++)
            {
                if (a[xIdx - 1] != b[xIdx])
                    return false;
            }
        }
        
        return true;
    }
}
