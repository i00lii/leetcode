// https://leetcode.com/problems/subsets/description/
using System.Collections.Immutable;

public class Solution 
{
    public IList<IList<int>> Subsets(int[] nums) 
    {
        List<IList<int>> result = new ();
        ImmutableArray<int> buffer = ImmutableArray<int>.Empty;
        result.Add(buffer);
        
        Generate(nums, 0, buffer, result);
        return result;
    }
    
    private static void Generate(int[] nums, int start, ImmutableArray<int> buffer, List<IList<int>> result)
    {
        for (int idx = start; idx < nums.Length; idx++)
        {
            ImmutableArray<int> current = buffer.Add(nums[idx]);
            result.Add(current);

            Generate(nums, idx + 1, current, result);
        }
    }
}
