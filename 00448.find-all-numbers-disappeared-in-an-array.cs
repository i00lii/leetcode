// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
public class Solution 
{
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        List<int> result = new();
        
        foreach (int i in nums)
        {
            ref int x = ref nums[Math.Abs(i) - 1];
            x = -Math.Abs(x);
        }
        
        for (int idx = 0; idx < nums.Length; idx++)
        {
            if (nums[idx] > 0) result.Add(idx + 1);
        }
        
        return result;
    }
}
