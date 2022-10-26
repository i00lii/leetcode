// https://leetcode.com/problems/continuous-subarray-sum/description/
public class Solution 
{
    public bool CheckSubarraySum(int[] nums, int k) 
    {
        Dictionary<int, int> buffer = new Dictionary<int, int>();
        buffer[0] = 0;
        
        int totalAmount = 0;
        
        for(int idx = 0; idx < nums.Length; idx++)
        {
            totalAmount += nums[idx];
            int reminder = totalAmount % k;
            
            if (!buffer.ContainsKey(reminder))
            {
                buffer[reminder] = idx + 1;
            }
            else if (buffer[reminder] < idx)
            {
                return true;
            }
        }
        
        return false;
    }
}
