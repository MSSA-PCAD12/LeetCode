using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Heap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Heap.Tests
{
    [TestClass()]
    public class KthLargestElementTests
    {
        [TestMethod()]
        public void FindKthLargestTest()
        {
            int[] nums = [3, 2, 1, 5, 6, 4];
            int k = 2;
            int actual = new KthLargestElement().FindKthLargest(nums, k);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindKthLargestTest2()
        {
            int[] nums = [3, 2, 3, 1, 2, 4, 5, 5, 6];
            int k = 4;
            int actual = new KthLargestElement().FindKthLargest(nums, k);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}