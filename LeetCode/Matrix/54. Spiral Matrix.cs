using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> res = new List<int>();
            int top = 0, left = 0, right = matrix[0].Length - 1, bot = matrix.Length - 1, elements = matrix.Length * matrix[0].Length;

            while (res.Count < elements)
            {
                // Go right 
                for (int i = left; i <= right && res.Count < elements; i++)
                {
                    res.Add(matrix[top][i]);
                }
                top++;

                // Go down
                for (int j = top; j <= bot && res.Count < elements; j++)
                {
                    res.Add(matrix[j][right]);
                }
                right--;

                // Go left
                for (int i = right; i >= left && res.Count < elements; i--)
                {
                    res.Add(matrix[bot][i]);
                }
                bot--;

                // Go up
                for (int i = bot; i >= top && res.Count < elements; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
            }

            return res;
        }
    }
}
