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
    public class SpiralMatrixTests
    {
        private SpiralMatrix spiralMatrix;

        [TestInitialize]
        public void Initialize()
        {
            // Initialize your SpiralMatrix instance here (if needed)
            spiralMatrix = new SpiralMatrix();
        }

        [TestMethod]
        public void SpiralOrder_ValidMatrix_ReturnsCorrectOrder()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
            };

            // Act
            var result = spiralMatrix.SpiralOrder(matrix);

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, result.ToArray());
        }

        [TestMethod]
        public void SpiralOrder_ValidMatrix_ReturnsCorrectOrder2()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
              new int[] { 1, 2, 3, 4, 5 },
              new int[] { 6, 7, 8, 9, 10 },
              new int[] { 11, 12, 13, 14, 15 },
              new int[] { 16, 17, 18, 19, 20 },
              new int[] { 21, 22, 23, 24, 25 }
            };

            // Act
            var result = spiralMatrix.SpiralOrder(matrix);

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 10, 15, 20, 25, 24, 23, 22, 21, 16, 11, 6, 7, 8, 9, 14, 19, 18, 17, 12, 13 }, result.ToArray());
        }
    }
}