// https://leetcode.com/problems/permutations/description/
public class Solution 
{
    public IList<IList<int>> Permute(int[] nums) 
    {
        List<IList<int>> result = new();
        Permute(nums, 0, result);
        return result;
    }

    private static void Permute(int[] nums, int offset, List<IList<int>> result)
    {  
        for (int idx = offset; idx < nums.Length; idx++)
        {
            Swap(nums, offset, idx);
            Permute(nums, offset + 1, result);
            Swap(nums, idx, offset);
        }

        if (offset == nums.Length - 1)
        {
            int[] r = new int[nums.Length];
            nums.CopyTo(r, 0);
            result.Add(r);
        }
    }

    private static void Swap(int[] nums, int x, int y)
    {
        int tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}

