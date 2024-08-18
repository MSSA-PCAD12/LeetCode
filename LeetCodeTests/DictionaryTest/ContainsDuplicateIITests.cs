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
    public class ContainsDuplicateIITests
    {
        [TestMethod()]
        public void ContainsNearbyDuplicateTest()
        {
            int[] nums = [1, 2, 3, 1];
            int k = 3;
            bool expected = true;
            bool actual = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ContainsNearbyDuplicateTest2()
        {
            int[] nums = [1, 0, 1, 1];
            int k = 1;
            bool expected = true;
            bool actual = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ContainsNearbyDuplicateTest3()
        {
            int[] nums = [1, 2, 3, 1, 2, 3];
            int k = 2;
            bool expected = false;
            bool actual = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, actual);
        }
    }
}