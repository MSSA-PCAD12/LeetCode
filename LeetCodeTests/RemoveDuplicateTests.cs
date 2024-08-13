using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass]
    public class RemoveDuplicateTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            int[] nums = nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int expected = 5;
            int[] expectedNums = [0, 1, 2, 3, 4];
            RemoveDuplicate tester = new();
            int actual = tester.RemoveDuplicates(nums);
            Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expectedNums, nums[0..expected]);
        }
        [TestMethod()]
        public void RemoveDuplicatesTest2()
        {
            int[] nums = nums = [1, 1, 2];
            int expected = 2;
            int[] expectedNums = [1, 2];
            RemoveDuplicate tester = new();
            int actual = tester.RemoveDuplicates(nums);
            Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expectedNums, nums[0..expected]);
        }
    }
}