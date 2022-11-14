// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
public class Solution 
{
    private static readonly int[] _stub = new int[]{-1, -1};

    public int[] SearchRange(int[] nums, int target) 
    {
        if (nums.Length == 0) return _stub;

        int l = FindLeft(nums, target);
        if (l == -1) return _stub;
        
        int r = FindRight(nums, l, target);

        return new int[]{l, r};
    } 
    
    private static int FindRight(int[] nums, int l, int target)
    {
        int r = nums.Length - 1;
        
        while (r - l > 1)
        {
            int m = l + (r - l) / 2;
            if (nums[m] > target) r = m;
            else l = m;
        }
        
        return nums[r] == target ? r : l;
    }
    
    private static int FindLeft(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        
        while (r - l > 1)
        {
            int m = l + (r - l) / 2;
            if (nums[m] >= target) r = m;
            else l = m;
        }
        
        return nums[l] == target ? l : nums[r] == target ? r : -1;
    }
}
