// https://leetcode.com/problems/single-number/description/
public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        int result = 0;

        foreach(int value in nums)
        {
            result ^= value;
        }

        return result;
    }
}
