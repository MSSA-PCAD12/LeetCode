using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix.Tests
{
    [TestClass()]
    public class RotateMatrixTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            // Act

            new RotateMatrix().Rotate(matrix);
            // Assert
            CollectionAssert.AreEqual(new int[] { 7, 4, 1 }, matrix[0]);
            CollectionAssert.AreEqual(new int[] { 8, 5, 2 }, matrix[1]);
            CollectionAssert.AreEqual(new int[] { 9, 6, 3 }, matrix[2]);
        }
        [TestMethod]
        public void Rotate_ValidMatrix_RotatesCorrectly2()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 5, 1, 9, 11 },
                new int[] { 2, 4, 8, 10 },
                new int[] { 13, 3, 6, 7 },
                new int[] { 15, 14, 12, 16 }
            };

            // Act
            new RotateMatrix().Rotate(matrix);

            // Assert
            CollectionAssert.AreEqual(new int[] { 15, 13, 2, 5 }, matrix[0]);
            CollectionAssert.AreEqual(new int[] { 14, 3, 4, 1 }, matrix[1]);
            CollectionAssert.AreEqual(new int[] { 12, 6, 8, 9 }, matrix[2]);
            CollectionAssert.AreEqual(new int[] { 16, 7, 10, 11 }, matrix[3]);
        }
    }
}