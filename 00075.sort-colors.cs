// https://leetcode.com/problems/sort-colors/description/
public class Solution 
{
    public void SortColors(int[] nums) 
    {
        int l = 0, m = 0;
        int r = nums.Length - 1;

        while (r >= m)
        {
            if (nums[m] == 1) m++;
            else if (nums[m] == 0) Swap(nums, l++, m++);
            else Swap(nums, m, r--);
        }
    }

    private static void Swap(int[] nums, int x, int y)
    {
        int t = nums[x];
        nums[x] = nums[y];
        nums[y] = t;
    }
}
