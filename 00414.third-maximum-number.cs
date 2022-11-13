// https://leetcode.com/problems/third-maximum-number/description/
public class Solution 
{
    public int ThirdMax(int[] nums) 
    {
        int? x = default;
        int? z = default;
        int? y = default;
        
        for (int idx = 0; idx < nums.Length; idx++)
        {
            int current = nums[idx];
            
            if (!x.HasValue || x == current)
            {
                x = current;
                continue;
            }
            
            if (current > x)
            {
                z = y;
                y = x;
                x = current;
                continue;
            }
            
            if (!y.HasValue || y == current)
            {
                y = current;
                continue;
            }
            
            if (current > y)
            {
                z = y;
                y = current;
                continue;
            } 
            
            if (!z.HasValue || current > z)
            {
                z = current;
                continue;
            }
        }
        
        return z.HasValue ? z.Value : x.Value;
    }
}
