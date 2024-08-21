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
    public class MaxDepthBinaryTreeTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            var node = BinaryTreeHelper.BuildTree([3, 9, 20, null, null, 15, 7]);
            int expected = 3;
            int actual = new MaxDepthBinaryTree().MaxDepth(node!).Result;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxDepthTest2()
        {
            var node = BinaryTreeHelper.BuildTree([1, null, 2]);
            int expected = 2;
            int actual = new MaxDepthBinaryTree().MaxDepth(node!).Result;
            Assert.AreEqual(expected, actual);
        }
    }

    

}