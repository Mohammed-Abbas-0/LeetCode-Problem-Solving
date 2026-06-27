public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0]; 
        int maxProfit = 0;  
        for(int i = 0; i < prices.Length; i++)
        {
            minPrice = Math.Min(prices[i],minPrice);
            maxProfit = Math.Max(prices[i] - minPrice, maxProfit);
        }

        return maxProfit;
    }
}