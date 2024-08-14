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
    public class MajorityEventTests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            int[] nums = [3, 2, 3];
            int expected = 3;
            MajorityEvent m = new();
            var actual= m.MajorityElement(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MajorityElementTest2()
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            int expected = 2;
            MajorityEvent m = new();
            var actual = m.MajorityElement(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}