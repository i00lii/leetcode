// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int buy = prices[0];
        int profit = 0;

        foreach(int price in prices)
        {    
            if (price > buy)
            {
                profit = Math.Max(profit, price - buy);
            }
            else 
            {
                buy = price;
            }
        }

        return profit;
    }
}
