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
    public class CircularSubarraySumTests
    {
        [TestMethod]
        public void TestMaxSubarraySumCircular_AllPositiveNumbers()
        {
            // Arrange
            var circularSubarraySum = new CircularSubarraySum();
            int[] nums = { 1, 2, 3, 4, 5 };

            // Act
            int result = circularSubarraySum.MaxSubarraySumCircular(nums);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMaxSubarraySumCircular_AllNegativeNumbers()
        {
            // Arrange
            var circularSubarraySum = new CircularSubarraySum();
            int[] nums = { -1, -2, -3, -4, -5 };

            // Act
            int result = circularSubarraySum.MaxSubarraySumCircular(nums);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMaxSubarraySumCircular_MixedNumbers()
        {
            // Arrange
            var circularSubarraySum = new CircularSubarraySum();
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // Act
            int result = circularSubarraySum.MaxSubarraySumCircular(nums);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMaxSubarraySumCircular_SingleElement()
        {
            // Arrange
            var circularSubarraySum = new CircularSubarraySum();
            int[] nums = { 5 };

            // Act
            int result = circularSubarraySum.MaxSubarraySumCircular(nums);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMaxSubarraySumCircular_EmptyArray()
        {
            // Arrange
            var circularSubarraySum = new CircularSubarraySum();
            int[] nums = { };

            // Act & Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => circularSubarraySum.MaxSubarraySumCircular(nums));
        }

        [TestMethod]
        public void TestMaxSubarraySumCircular_CircularWrapAround()
        {
            // Arrange
            var circularSubarraySum = new CircularSubarraySum();
            int[] nums = { 5, -3, 5 };

            // Act
            int result = circularSubarraySum.MaxSubarraySumCircular(nums);

            // Assert
            Assert.AreEqual(10, result);
        }
    }
}