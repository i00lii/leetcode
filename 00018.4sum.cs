// https://leetcode.com/problems/4sum/description/
public class Solution 
{
    public IList<IList<int>> FourSum(int[] nums, int target) 
    {
        Array.Sort(nums);
        List<IList<int>> result = new();
        
        for(int aIdx = 0; aIdx < nums.Length - 3;)
        {
            int aValue = nums[aIdx];
            
            for(int bIdx = aIdx + 1; bIdx < nums.Length - 2;)
            {
                int bValue = nums[bIdx];
                    
                long currentTarget = (long)target - aValue - bValue;
                int cIdx = bIdx + 1;
                int dIdx = nums.Length - 1;

                while (dIdx > cIdx)
                {
                    int cValue = nums[cIdx];
                    int dValue = nums[dIdx];
                    long summa = (long)cValue + dValue;

                    if (summa == currentTarget) result.Add(new int[]{aValue, bValue, cValue, dValue});
                    if (summa >= currentTarget) do {dIdx--;} while(dIdx > cIdx && nums[dIdx] == dValue);
                    if (summa <= currentTarget) do {cIdx++;} while(dIdx > cIdx && nums[cIdx] == cValue);
                }

                do {bIdx++;} while(bIdx < nums.Length - 2 && nums[bIdx] == bValue);
            }

            do {aIdx++;} while(aIdx < nums.Length - 3 && nums[aIdx] == aValue);
        }

        return result;
    }
}
