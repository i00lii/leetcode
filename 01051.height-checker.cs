// https://leetcode.com/problems/height-checker/description/
public class Solution 
{
    public int HeightChecker(int[] heights) 
    {
        int[] buffer = new int[heights.Length];
        Array.Copy(heights, 0, buffer, 0, buffer.Length);
        Array.Sort(buffer);
        
        int count = 0;
        for (int idx = 0; idx < buffer.Length; idx++)
        {
            if (heights[idx] != buffer[idx])
            {
                count++;
            }
        }
        
        return count;
    }
}
