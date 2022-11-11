// https://leetcode.com/problems/pascals-triangle-ii/description/
public class Solution 
{
    public IList<int> GetRow(int numRows) 
    {
        int[] buffer = new int[numRows + 1];
        
        for (int row = 0; row <= numRows; row++)
        {  
            int idx = numRows - row;
            buffer[idx++] = 1;

            for (; idx <= numRows - 1; idx++)
            {
                buffer[idx] = buffer[idx] + buffer[idx + 1];
            }
        }

        return buffer;
    }
}
