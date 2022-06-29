using System.Linq;

public class Solution {
    public int MaxProfit(int[] prices) {

        int max_profit = 0;

        int min_buy = prices.Max();

        for (int i = 0; i < prices.Length; i++) {
            if(min_buy > prices[i])
                min_buy = prices[i];
            if(prices[i] - min_buy > max_profit)
                max_profit = prices[i] - min_buy;
        }

        return max_profit;
    }
}
