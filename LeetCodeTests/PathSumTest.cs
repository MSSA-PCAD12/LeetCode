using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class PathSumTest
    {
        [TestMethod()]
        public void PathSumTest1()
        {
            var input = BinaryTreeHelper.BuildTree([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);
            int targetSum = 22;
            var expected = true;
            var actual = new PathSum().HasPathSum(input!,targetSum);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void PathSumTest2()
        {
            var input = BinaryTreeHelper.BuildTree([1, 2, 3]);
            int targetSum = 5;
            var expected = false;
            var actual = new PathSum().HasPathSum(input!, targetSum);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void PathSumTest3()
        {
            var input = BinaryTreeHelper.BuildTree([]);
            int targetSum = 0;
            var expected = false;
            var actual = new PathSum().HasPathSum(input!, targetSum);
            Assert.AreEqual(actual, expected);
        }
    }
}
