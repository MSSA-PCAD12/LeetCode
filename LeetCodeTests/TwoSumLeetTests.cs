using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class TwoSumLeetTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] nums = [2, 7, 11, 15];
            int sum = 9;
            int[] expected = [0, 1];
            int[] actual = new TwoSumLeet().TwoSum(nums, sum);
            CollectionAssert.AreEquivalent(actual, expected);
        }
        [TestMethod()]
        public void TwoSumTest2()
        {
            int[] nums = [3, 2, 4];
            int sum = 6;
            int[] expected = [1, 2];
            int[] actual = new TwoSumLeet().TwoSum(nums, sum);
            CollectionAssert.AreEquivalent(actual, expected);
        }
        [TestMethod()]
        public void TwoSumTest3()
        {
            int[] nums = [0,4,3,0];
            int sum = 0;
            int[] expected = [0, 3];
            int[] actual = new TwoSumLeet().TwoSum(nums, sum);
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}