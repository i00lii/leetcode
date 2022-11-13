// https://leetcode.com/problems/find-pivot-index/description
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int total = 0;
        
        for (int idx = 0; idx < nums.Length; idx++)
        {
            total += nums[idx];
        }    

        int left = 0;
        int right = total;

        for (int idx = 0; idx < nums.Length; idx++)
        {
            int current = nums[idx];
            right -= current; 

            if (left == right)
            {
                return idx;
            }

            left += current;
        }

        return -1;
    }
}
