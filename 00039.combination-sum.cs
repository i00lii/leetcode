// https://leetcode.com/problems/combination-sum/
public class Solution 
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        List<IList<int>> result = new ();
        Generate(candidates, 0, target, new List<int>(), result);
        return result;
    }

    private static void Generate
    (
        int[] candidates,
        int offset,
        int target,
        List<int> buffer,
        List<IList<int>> result
    )
    {
        if (target == 0)
        {
            result.Add(buffer.ToArray());
            return;
        }

        for(; offset < candidates.Length; offset++)
        {
            int number = candidates[offset];
            int maxK = target / number;

            if (maxK > 0)
            {
                for (int k = 1; k <= maxK; k++)
                {
                    buffer.Add(number);
                    Generate(candidates, offset + 1, target - k * number, buffer, result); 
                }

                buffer.RemoveRange(buffer.Count - maxK, maxK);
            }
        }
    }
}
