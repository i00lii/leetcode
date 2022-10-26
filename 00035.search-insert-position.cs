// https://leetcode.com/problems/search-insert-position/description/
public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        int xIdx = 0;
        int yIdx = nums.Length - 1;
        
        if (target <= nums[xIdx])
            return xIdx;
        
        if (target == nums[yIdx])
            return yIdx;
        
        if (target > nums[yIdx])
            return ++yIdx;
        
        while (yIdx - xIdx > 1)
        {
            int middleIdx = xIdx + (yIdx - xIdx) / 2;
            int middleValue = nums[middleIdx];
            
            if (middleValue == target)
            {
                return middleIdx;
            }
            else if (target > middleValue)
            {
                xIdx = middleIdx;
            }
            else
            {
                yIdx = middleIdx;
            }
        }
        
        return yIdx;
    }
}
