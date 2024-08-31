using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers.Tests
{
    [TestClass()]
    public class ThreeSumLeetTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            int[] nums = [-1, 0, 1, 2, -1, -4];
            List<List<int>> expected = [[-1, -1, 2], [-1, 0, 1]];
            List<List<int>> actual = new ThreeSumLeet().ThreeSum(nums);
            for (int i = 0; i < expected.Count - 1; i++)
            {
                CollectionAssert.AreEqual(actual[i],expected[i]);
            }
        }
        [TestMethod()]
        public void ThreeSumTest2()
        {
            int[] nums = [0, 1, 1];
            List<List<int>> expected = [];
            List<List<int>> actual = new ThreeSumLeet().ThreeSum(nums);
            for (int i = 0; i < expected.Count - 1; i++)
            {
                CollectionAssert.AreEqual(actual[i], expected[i]);
            }
        }
        [TestMethod()]
        public void ThreeSumTest3()
        {
            int[] nums = [0, 0, 0];
            List<List<int>> expected = [];
            List<List<int>> actual = new ThreeSumLeet().ThreeSum(nums);
            for (int i = 0; i < expected.Count - 1; i++)
            {
                CollectionAssert.AreEqual(actual[i], expected[i]);
            }
        }
    }
}