// https://leetcode.com/problems/search-in-rotated-sorted-array/description/
public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int l = 0;
        int r = nums.Length - 1;

        while (r >= l)
        {
            int m = l + (r - l) / 2;
            
            int valueL = nums[l];
            int valueR = nums[r];
            int valueM = nums[m];

            if (valueM == target)
                return m;

            if (valueL == target)
                return l;

            if (valueR == target)
                return r;

            if (valueM < valueR)
            {
                if (target > valueM && target < valueR)
                {
                    l = m + 1;
                }
                else 
                {
                    r = m - 1;
                }
            }
            else
            {
                if (target < valueM && target > valueL)
                {
                    r = m - 1;
                }
                else 
                {
                    l = m + 1;
                }
            }
        }

        return -1;
    }
}
