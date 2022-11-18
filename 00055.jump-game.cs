// https://leetcode.com/problems/jump-game/description/
public class Solution 
{
    public bool CanJump(int[] nums)
    {
        int target = nums.Length - 1;

        for (int index = nums.Length - 1; index >= 0; index--)
        {
            if (nums[index] + index >= target)
            {
                target = index;
            }
        }

        return (target == 0);
    }
}
