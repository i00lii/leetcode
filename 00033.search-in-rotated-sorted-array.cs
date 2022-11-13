// https://leetcode.com/problems/search-in-rotated-sorted-array/description/
public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;

        // no rotation
        if (nums[0] < nums[nums.Length - 1])
        {
            int r = Array.BinarySearch(nums, target);
            return r >= 0 ? r : -1;    
        }

        int rotationIdx = FindRoatationIdx(nums);
        int nextIdx = rotationIdx + 1;
        
        if (target >= nums[0])
        {
            int r = Array.BinarySearch(nums, 0, nextIdx, target);
            return r >= 0 ? r : -1;
        }
        else 
        {
            int r = Array.BinarySearch(nums, nextIdx, nums.Length - nextIdx, target);
            return r >= 0 ? r : -1;
        }
    }

    private static int FindRoatationIdx(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (r - l > 1)
        {
            int valueL = nums[l];
            int valueR = nums[r];

            int m = l + (r - l) / 2;
            int valueM = nums[m];

            if (valueM < valueR)
            {
                r = m;
                continue;
            }

            if (valueM > valueL)
            {
                l = m;
                continue;
            }
        }

        return l;
    }

}
