// https://leetcode.com/problems/where-will-the-ball-fall/description/
public class Solution 
{
    public int[] FindBall(int[][] grid) 
    {
        int[] buffer = new int[grid[0].Length];
        
        int sizeX = buffer.Length;
        int sizeY = grid.Length;
        
        for (int xIdx = 0; xIdx < sizeX; xIdx++)
        {
            buffer[xIdx] = TryTraverseGrid(xIdx, sizeX, sizeY, grid);
        }

        return buffer;
    }
    
    private static int TryTraverseGrid(int xIdx, int sizeX, int sizeY, int[][] grid)
    {   
        //  0 - from top
        // -1 - from left
        //  1 - from rigth
        int enteredFrom = 0;
        int yIdx = 0;
        
        while (yIdx < sizeY)
        {
            int current = grid[yIdx][xIdx];
            
            if (enteredFrom == 0)
            {
                (xIdx, enteredFrom) = current == 1 ? (xIdx + 1, -1) : (xIdx - 1, 1);
                
                if (xIdx >= sizeX || xIdx < 0)
                    return -1;
            }
            else if (enteredFrom == current)
            {
                return -1;
            }
            else 
            {  
                (yIdx, enteredFrom) = (yIdx + 1, 0);   
            }
        }
        
        return xIdx;
    }
}
