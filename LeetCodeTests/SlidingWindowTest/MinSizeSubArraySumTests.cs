using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow.Tests
{
    [TestClass()]
    public class MinSizeSubArraySumTests
    {
        [TestMethod]
        public void TestMinSubArrayLen()
        {
            // Arrange
            var solution = new MinSizeSubArraySum();
            int target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };

            // Act
            int result = solution.MinSubArrayLen(target, nums);

            // Assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMinSubArrayLen_NoValidSubArray()
        {
            // Arrange
            var solution = new MinSizeSubArraySum();
            int target = 100;
            int[] nums = { 1, 2, 3, 4, 5 };

            // Act
            int result = solution.MinSubArrayLen(target, nums);

            // Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestMinSubArrayLen_SingleElement()
        {
            // Arrange
            var solution = new MinSizeSubArraySum();
            int target = 4;
            int[] nums = { 4 };

            // Act
            int result = solution.MinSubArrayLen(target, nums);

            // Assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMinSubArrayLen_EmptyArray()
        {
            // Arrange
            var solution = new MinSizeSubArraySum();
            int target = 4;
            int[] nums = { };

            // Act
            int result = solution.MinSubArrayLen(target, nums);

            // Assert
            Assert.AreEqual(0, result);
        }

    }
}