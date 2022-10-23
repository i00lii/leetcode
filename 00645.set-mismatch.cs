// https://leetcode.com/problems/set-mismatch/description/
public class Solution 
{
    public int[] FindErrorNums(int[] nums) 
    {
        int[] buffer = new int[nums.Length];
        int[] result = new int[2];

        for (int idx = 0; idx < nums.Length; idx++)
        {
            buffer[nums[idx] - 1]++;
        }
        
        for (int idx = 0; idx < nums.Length; idx++)
        {
            if (buffer[idx] == 0)
            {
                result[1] = idx + 1;
                
                if (result[0] != default)
                    break;
            }
            else if (buffer[idx] == 2)
            {
                result[0] = idx + 1;
                
                if (result[1] != default)
                    break;
            }
        }
        return result;
    }
}
