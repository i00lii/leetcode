// https://leetcode.com/problems/min-cost-climbing-stairs/description/
public class Solution 
{
    public int MinCostClimbingStairs(int[] cost) 
    {
        int priceMinus1 = 0;
        int priceMinus2 = 0;

        for (int idx = 2; idx <= cost.Length; idx++)
        {
            int p2 = priceMinus2 + cost[idx - 2];
            int p1 = priceMinus1 + cost[idx - 1];

            priceMinus2 = priceMinus1;
            priceMinus1 = Math.Min(p1, p2);
        }

        return priceMinus1;
    }
}
