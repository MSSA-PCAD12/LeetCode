using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class InvertTreeTest
    {
        [TestMethod()]
        public void InvertTreeTest1()
        {
            var input = BinaryTreeHelper.BuildTree([4, 2, 7, 1, 3, 6, 9]);
            var expected = BinaryTreeHelper.BuildTree([4, 7, 2, 9, 6, 3, 1]);
            var actual = new InvertTreeLeet().InvertTree(input!);
            Assert.IsTrue(new SameTree().IsSameTree(actual!, expected!));
        }
        [TestMethod()]
        public void InvertTreeTest2()
        {
            var input = BinaryTreeHelper.BuildTree([]);
            var expected = BinaryTreeHelper.BuildTree([]);
            var actual = new InvertTreeLeet().InvertTree(input!);
            Assert.IsTrue(new SameTree().IsSameTree(actual!, expected!));
        }
    }
}
