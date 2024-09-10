using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString.Tests
{
    [TestClass()]
    public class RotateArrayLeetTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int[] expected = [5, 6, 7, 1, 2, 3, 4];
            int k = 3;
            new RotateArrayLeet().Rotate(nums, k);
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}