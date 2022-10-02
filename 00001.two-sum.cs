// https://leetcode.com/problems/two-sum/
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> cache = new Dictionary<int, int>();

        for (int idx = 0; idx < nums.Length; idx++)
        {
            int current = nums[idx];
            int lookup = target - current;

            if (cache.TryGetValue(lookup, out int lookupIdx))
                return new int[] {lookupIdx, idx};

            cache.TryAdd(current, idx);
        }

        throw null;
    }
}
