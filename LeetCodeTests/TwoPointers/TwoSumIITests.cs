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
    public class TwoSumIITests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] numbers = [2, 7, 11, 15];
            int target = 9;
            int[] expected = [1, 2];
            int[] actual=new TwoSumII().TwoSum(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest2()
        {
            int[] numbers = [2, 3, 4];
            int target = 6;
            int[] expected = [1, 3];
            int[] actual = new TwoSumII().TwoSum(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest3()
        {
            int[] numbers = [2, 7, 11, 15];
            int target = 9;
            int[] expected = [1, 2];
            int[] actual = new TwoSumII().TwoSum2(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest4()
        {
            int[] numbers = [2, 3, 4];
            int target = 6;
            int[] expected = [1, 3];
            int[] actual = new TwoSumII().TwoSum2(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest5()
        {
            int[] numbers = [2, 7, 11, 15];
            int target = 9;
            int[] expected = [1, 2];
            int[] actual = new TwoSumII().TwoSum3(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest6()
        {
            int[] numbers = [2, 3, 4];
            int target = 6;
            int[] expected = [1, 3];
            int[] actual = new TwoSumII().TwoSum3(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest7()
        {
            int[] numbers = [0, 0, 3, 4];
            int target = 0;
            int[] expected = [1, 2];
            int[] actual = new TwoSumII().TwoSum3(numbers, target);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}