namespace LeetCode.Controllers
{
    public class No_121_Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int left = 0; 
            int right = 1; 
            int maxProfit = 0;

            while (right < prices.Length)
            {
                if (prices[right] > prices[left])
                {
                    int profit = prices[right] - prices[left];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    left = right;
                }
                right++;
            }

            return maxProfit;
        }
    }
}
