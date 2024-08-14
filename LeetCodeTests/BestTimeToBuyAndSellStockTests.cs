using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode.Tests
{
    [TestClass()]
    public class BestTimeToBuyAndSellStockTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            int[] prices = [7, 1, 5, 3, 6, 4];
            int expected = 5;
            BestTimeToBuyAndSellStock b = new();
            int actual = b.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxProfitTest2()
        {
            int[] prices = [7, 6, 4, 3, 1];
            int expected = 0;
            BestTimeToBuyAndSellStock b = new();
            int actual = b.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }
    }
}