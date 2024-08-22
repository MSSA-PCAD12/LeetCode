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
    public class MinimumDiffTests
    {
        [TestMethod()]
        public void GetMinimumDifferenceTest()
        {
            var root = BinaryTreeHelper.BuildTree([4, 2, 6, 1, 3]);
            int expected = 1;
            int actual = new MinimumDiff().GetMinimumDifference(root!);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetMinimumDifferenceTest2()
        {
            var root = BinaryTreeHelper.BuildTree([1, 0, 48, null, null, 12, 49]);
            int expected = 1;
            int actual = new MinimumDiff().GetMinimumDifference(root!);
            Assert.AreEqual(expected, actual);
        }
    }
}