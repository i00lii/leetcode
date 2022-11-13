// https://leetcode.com/problems/sort-array-by-parity/description/
public class Solution 
{
    public int[] SortArrayByParity(int[] nums) 
    {
        int x = 0;
        int y = nums.Length - 1;
        
        while (y > x)
        {
            int valueX = nums[x];
            int valueY = nums[y];
            
            if (valueX % 2 == 0)
            {
                x++;
                continue;
            }
            
            if (valueY % 2 == 1)
            {
                y--;
                continue;
            }
            
            nums[x] = valueY;
            nums[y] = valueX;
            
            y--;
            x++;   
        }
        
        return nums;
    }
}
