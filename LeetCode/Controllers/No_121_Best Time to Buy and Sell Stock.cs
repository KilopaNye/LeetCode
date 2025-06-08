using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Transactions;

namespace LeetCode.Controllers
{
    public class No_121_Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int left = 0; 
            int right = 1; 
            int result = 0;

            while (right < prices.Length)
            {
                if (prices[right] < prices[left])
                {
                    left = right;
                }
                else
                {
                    int profit = prices[right] - prices[left];
                    result = Math.Max(result, profit);
                }
                right++;
            }

            return result;
        }
    }
}

//URL: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

//121. Best Time to Buy and Sell Stock

//You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 
//Example 1:

//Input: prices = [7,1,5,3,6,4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

//Example 2:

//Input: prices = [7,6,4,3,1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.

 
//Constraints:

//	1 <= prices.length <= 105
//	0 <= prices[i] <= 104URL: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

//121. Best Time to Buy and Sell Stock

//You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 
//Example 1:

//Input: prices = [7,1,5,3,6,4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

//Example 2:

//Input: prices = [7,6,4,3,1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.

 
//Constraints:

//	1 <= prices.length <= 105
//	0 <= prices[i] <= 104
