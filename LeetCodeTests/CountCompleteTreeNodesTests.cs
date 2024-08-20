using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class CountCompleteTreeNodesTests
    {
        [TestMethod()]
        public void CountNodesTest()
        {
            var root=BinaryTreeHelper.BuildTree([1, 2, 3, 4, 5, 6]);
            int expected = 6;
            int actual = new CountCompleteTreeNodes().CountNodes(root);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountNodesTest2()
        {
            var root = BinaryTreeHelper.BuildTree([1, 2, 3, 4]);
            int expected = 4;
            int actual = new CountCompleteTreeNodes().CountNodes(root);
            Assert.AreEqual(expected, actual);
        }
    }
}