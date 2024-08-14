using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int largestProfit = 0;
            int lowestPriceSofar = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < lowestPriceSofar) // is this a new low price so far? 
                {
                    lowestPriceSofar = prices[i];// update the lowestPriceSoFar
                }
                else 
                {
                    largestProfit = Math.Max(largestProfit, prices[i]-lowestPriceSofar);//price is higher, is the profit the highest we have seen?
                }

            }

            return largestProfit;
        }
    }
}
