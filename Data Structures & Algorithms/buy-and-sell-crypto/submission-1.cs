public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int bestStock = 0;
        for(int i = 1; i < prices.Count(); i++)
        {
            if(prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            bestStock = (prices[i] - minPrice) > bestStock ?  (prices[i] - minPrice) : bestStock;
        }
        return bestStock;
    }
}