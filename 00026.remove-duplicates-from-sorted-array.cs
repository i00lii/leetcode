// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int old = nums[0];
        
        int shift = 0;        
        for(int idx = 1; idx < nums.Length; idx++)
        {
            int current = nums[idx];
        
            if (current == old)
            {
                shift++;
            }
            else
            {
                old = current;
                nums[idx - shift] = current;
            }
        }
        
        return nums.Length - shift;
    }
}
