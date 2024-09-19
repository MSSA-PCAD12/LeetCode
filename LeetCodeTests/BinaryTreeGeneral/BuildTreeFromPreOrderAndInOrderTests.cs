using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using LeetCode.Tests;

namespace LeetCode.BinaryTreeGeneral.Tests
{
    [TestClass()]
    public class BuildTreeFromPreOrderAndInOrderTests
    {
        [TestMethod()]
        public void BuildTreeTest()
        {
            int[] preorder = [3, 9, 20, 15, 7], inorder = [9, 3, 15, 20, 7];
            var expected = BinaryTreeHelper.BuildTree([3, 9, 20, null, null, 15, 7]);

            var actual = new BuildTreeFromPreOrderAndInOrder().BuildTree(preorder, inorder);
            Assert.IsTrue(new SameTree().IsSameTree(expected!, actual!));
        }

        
    }
}