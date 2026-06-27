public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = prices[0],maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            minBuy = Math.Min(prices[i],minBuy);
            maxProfit = Math.Max(prices[i] - minBuy,maxProfit);
        }
        return  maxProfit;

    }
}