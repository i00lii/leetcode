// https://leetcode.com/problems/maximum-subarray/description/
public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int max = int.MinValue;
        int sum = 0;

        foreach (int n in nums)
        {
            sum = Math.Max(n, sum + n);
            max = Math.Max(max, sum);
        }

        return max;
    }
}
