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
    public class MergeSortedArrayTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            //arrange
            MergeSortedArray m = new MergeSortedArray();
            //act
            int[] num1 = [1, 2, 3, 0, 0, 0];
            int[] num2 = [2, 5, 6];
            int[] expected = [1, 2, 2, 3, 5, 6];
            m.Merge(num1, 3, num2, 3);
            //assert
          CollectionAssert.AreEqual(expected, num1);
        }

        [TestMethod()]
        public void MergeTest3()
        {
            //arrange
            MergeSortedArray m = new MergeSortedArray();
            //act
            int[] num1 = [0];
            int[] num2 = [1];
            int[] expected = [1];
            m.Merge(num1, 0, num2, 1);
            //assert
            CollectionAssert.AreEqual(expected, num1);
        }
    }
}