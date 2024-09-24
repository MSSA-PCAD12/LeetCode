using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchAlgo
{
    public class Search2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target) {
            if (matrix.Length==0) return false;
           int rol = matrix.Length;
           int col = matrix[0].Length;
           int end = (rol * col) -1;
           int start =0;
           while (end >= start) { 
                int mid  = (end - start) / 2;
                
                if (matrix.GetElement(start) == target ||
                    matrix.GetElement(mid) == target   ||
                    matrix.GetElement(end) == target
                    ) return true;
                if (mid == 0) { return false; } 
                if (target > matrix.GetElement(mid))
                    start = mid + 1;
                else
                    end = mid - 1;
           }
            return false;
            
        }
    }
    public static class MatrixHelper
    {
        public static int GetElement(this int[][] matrix, int index) {
            int row = index / matrix[0].Length;
            int col = index % matrix.Length;
            return matrix[row][col];

        }
    }
}
