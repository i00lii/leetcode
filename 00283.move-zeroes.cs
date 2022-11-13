// https://leetcode.com/problems/move-zeroes/description/
public class Solution
{
    public void MoveZeroes(int[] nums) 
    {
        int offset = 0;
        int length = 0;
        
        for (int idx = 0; idx < nums.Length; idx++)
        {
            if (nums[idx] == 0)
            {
                offset++;
                continue;
            }
            
            if (offset > 0)
            {
                nums[idx - offset] = nums[idx];
            }
            
            length++;
        }

        Array.Fill(nums, 0, length, nums.Length - length);
    }
}
