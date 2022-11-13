// https://leetcode.com/problems/running-sum-of-1d-array/description
public class Solution 
{
    public int[] RunningSum(int[] nums)
    {
        int total = 0;

        for (int idx = 0; idx < nums.Length; idx++)
        {
            total += nums[idx];
            nums[idx] = total;
        }   

        return nums;
    }
}
