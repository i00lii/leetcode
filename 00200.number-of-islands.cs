// https://leetcode.com/problems/number-of-islands/description/
public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        int sizeX = grid[0].Length;
        int sizeY = grid.Length;

        int islandCount = 0;

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                if (grid[y][x] == '1')
                {
                    islandCount++;
                    MarkAsVisited(x, y); 
                }
            }
        }

        return islandCount;

        void MarkAsVisited(int x, int y)
        {
            if (x < 0 || x >= sizeX || y < 0 || y >= sizeY)
                return;

            if (grid[y][x] == '0')
                return;

            grid[y][x] = '0';

            MarkAsVisited(x + 1, y);
            MarkAsVisited(x, y + 1);

            MarkAsVisited(x - 1, y);
            MarkAsVisited(x, y - 1);
        }
    }
}
