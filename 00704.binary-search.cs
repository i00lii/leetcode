// https://leetcode.com/problems/binary-search/description
public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int l = 0;
        int r = nums.Length - 1;

        while (r >= l)
        {
            int m = l + (r - l) / 2;
            int valueM = nums[m];

            if (valueM == target) return m;
            else if (valueM > target) r = m - 1;
            else l = m + 1;
        }

        return -1;
    }
}
