using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
    public class BestTimeToBuyAndSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                result = (prices[i] - prices[i - 1] > 0) ? result + prices[i] - prices[i - 1] : result;
            }
            return result;
        }
    }
}
