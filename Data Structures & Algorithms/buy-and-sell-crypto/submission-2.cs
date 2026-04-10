public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int bestStock = 0;
        for(int i = 1; i < prices.Count(); i++)
        {
            minPrice = prices[i] < minPrice ? prices[i] : minPrice;
            bestStock = (prices[i] - minPrice) > bestStock ?  (prices[i] - minPrice) : bestStock;
        }
        return bestStock;
    }
}