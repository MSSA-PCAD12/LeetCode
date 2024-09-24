using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinarySearchAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchAlgo.Tests
{
    [TestClass()]
    public class Search2DMatrixTests
    {
        [TestMethod()]
        public void SearchMatrixTest()
        {
            int[][] matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]];
            int target = 3;
            bool expected = true;
            bool actual = new Search2DMatrix().SearchMatrix(matrix, target);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void SearchMatrixTest2()
        {
            int[][] matrix = matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]];
            int target = 13;
            bool expected = false;
            bool actual = new Search2DMatrix().SearchMatrix(matrix, target);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void SearchMatrixTest3()
        {
            int[][] matrix = matrix = [[1]];
            int target = 1;
            bool expected = true;
            bool actual = new Search2DMatrix().SearchMatrix(matrix, target);
            Assert.AreEqual(expected, actual);

        }
    }
}