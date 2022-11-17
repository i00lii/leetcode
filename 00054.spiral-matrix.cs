// https://leetcode.com/problems/spiral-matrix/description/
public class Solution 
{
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        (int minX, int maxX) = (0, matrix[0].Length - 1);
        (int minY, int maxY) = (0, matrix.Length - 1);
        List<int> result = new((maxY + 1) * (maxX + 1));
        
        while (minX <= maxX && minY <= maxY)
        {
            for (int x = minX; x <= maxX; x++) result.Add(matrix[minY][x]);
            minY++;

            for (int y = minY; y <= maxY; y++) result.Add(matrix[y][maxX]);
            maxX--;

            for (int x = maxX; x >= minX && maxY >= minY; x--) result.Add(matrix[maxY][x]);
            maxY--;

            for (int y = maxY; y >= minY && maxX >= minX; y--) result.Add(matrix[y][minX]);
            minX++;
        }

        return result;
    }
}
