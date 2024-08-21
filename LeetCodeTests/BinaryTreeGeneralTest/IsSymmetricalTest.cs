using LeetCode.Tests;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.BinaryTreeGeneral;

namespace LeetCode.Tests
{
    [TestClass()]
    public class IsSymmetricalTest
    {
        [TestMethod()]
        public void SymmTreeTest1()
        {
            var input = BinaryTreeHelper.BuildTree([1, 2, 2, 3, 4, 4, 3]);
            var expected = true;
            var actual = new SymmTree().IsSymmetric(input!);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SymmTreeTest2()
        {
            var input = BinaryTreeHelper.BuildTree([1, 2, 2, null, 3, null, 3]);
            var expected = false;
            var actual = new SymmTree().IsSymmetric(input!);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void SymmTreeTest3()
        {
            var input = BinaryTreeHelper.BuildTree([1, 2, 2, 3, 4, 4, 3]);
            var expected = true;
            var actual = new SymmTree().IsSymmetric2(input!);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SymmTreeTest4()
        {
            var input = BinaryTreeHelper.BuildTree([1, 2, 2, null, 3, null, 3]);
            var expected = false;
            var actual = new SymmTree().IsSymmetric2(input!);
            Assert.AreEqual(actual, expected);
        }
    }
}
