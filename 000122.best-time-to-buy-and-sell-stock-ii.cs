// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int totalProfit = 0;

        for (int t0 = 0, t1 = 1; t1 < prices.Length; t0++, t1++)
        {
            int overnightProfit = prices[t1] - prices[t0];

            if (overnightProfit > 0)
            {
                totalProfit += overnightProfit;
            }
        }

        return totalProfit;
    }
}
