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
    public class BuildBSTTests
    {
        [TestMethod()]
        public void SortedArrayToBSTTest()
        {
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            var expected = BinaryTreeHelper.BuildTree([0, -3, 9, -10, null, 5]);
            var actual = new BuildBST().SortedArrayToBST(nums);
            var result = new SameTree().IsSameTree(expected!, actual!);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void SortedArrayToBSTTest2()
        {
            int[] nums = new int[] { 1, 3 };
            var expected = BinaryTreeHelper.BuildTree([3, 1]);
            var actual = new BuildBST().SortedArrayToBST(nums);
            var result = new SameTree().IsSameTree(expected!, actual!);
            Assert.IsTrue(result);
        }
    }
}