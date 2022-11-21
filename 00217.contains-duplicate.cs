// https://leetcode.com/problems/contains-duplicate/description
public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        Array.Sort(nums);

        for (int idx = 0; idx < nums.Length - 1; idx++)
        {
            if (nums[idx] == nums[idx + 1])
                return true;
        }

        return false;
    }
}
