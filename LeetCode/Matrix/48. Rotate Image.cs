using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class RotateMatrix
    {
        public void Rotate(int[][] matrix)
        {

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = row + 1; col < matrix[0].Length; col++)
                {
                    (matrix[col][row], matrix[row][col]) = (matrix[row][col], matrix[col][row]);
                }
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                Array.Reverse(matrix[row]);
            }
        }
    }
}
