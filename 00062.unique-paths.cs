// https://leetcode.com/problems/unique-paths/description/
public class Solution 
{
    public int UniquePaths(int m, int n) 
    {
        int[] buffer = new int[n + 1];
        buffer[1] = 1;
        
        for (int mIdx = 0; mIdx < m; mIdx++)
        {
            for (int nIdx = 1; nIdx <= n; nIdx++)
            {                
                buffer[nIdx] = buffer[nIdx - 1] + buffer[nIdx];
            }
        }

        return buffer[n];
    }
}
