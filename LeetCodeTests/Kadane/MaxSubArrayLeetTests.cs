using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Kadane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Kadane.Tests
{
    [TestClass]
    public class MaxSubArrayLeetTests
    {
        [TestMethod]
        public void TestMaxSubArray_AllPositiveNumbers()
        {
            // Arrange
            var maxSubArrayLeet = new MaxSubArrayLeet();
            int[] nums = { 1, 2, 3, 4, 5 };

            // Act
            int result = maxSubArrayLeet.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMaxSubArray_AllNegativeNumbers()
        {
            // Arrange
            var maxSubArrayLeet = new MaxSubArrayLeet();
            int[] nums = { -1, -2, -3, -4, -5 };

            // Act
            int result = maxSubArrayLeet.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMaxSubArray_MixedNumbers()
        {
            // Arrange
            var maxSubArrayLeet = new MaxSubArrayLeet();
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // Act
            int result = maxSubArrayLeet.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMaxSubArray_SingleElement()
        {
            // Arrange
            var maxSubArrayLeet = new MaxSubArrayLeet();
            int[] nums = { 5 };

            // Act
            int result = maxSubArrayLeet.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMaxSubArray_EmptyArray()
        {
            // Arrange
            var maxSubArrayLeet = new MaxSubArrayLeet();
            int[] nums = { };

            // Act & Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => maxSubArrayLeet.MaxSubArray(nums));
        }
    }
}