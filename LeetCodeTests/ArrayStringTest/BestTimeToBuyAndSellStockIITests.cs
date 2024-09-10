using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString.Tests
{
    [TestClass()]
    public class BestTimeToBuyAndSellStockIITests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            int[] prices = [1, 2, 3, 4, 5];
            int expected = 4;
            int actual = new BestTimeToBuyAndSellStockII().MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxProfitTest2()
        {
            int[] prices = [7, 1, 5, 3, 6, 4];
            int expected = 7;
            int actual = new BestTimeToBuyAndSellStockII().MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxProfitTest3()
        {
            int[] prices = [7, 6, 4, 3, 1];
            int expected = 0;
            int actual = new BestTimeToBuyAndSellStockII().MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }
    }
}