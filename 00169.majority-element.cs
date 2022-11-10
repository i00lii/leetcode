// https://leetcode.com/problems/majority-element/description/
public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        int result = nums[0];
        int count = 1; 

        for(int idx = 1; idx < nums.Length; idx++)
        {
            int current = nums[idx];
            
            if (current == result)
            {
                count++;
            }
            else
            {
                if (count == 0)
                {
                    result = current;
                    count = 1;
                }
                else
                {
                    count--;
                }
            }
        }

        return result;
    }
}
