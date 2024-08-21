using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSort
    {
        public int[] Sort(int[] input) {
            return DoMergeSort(input);
        }

        private int[] DoMergeSort(int[] input)
        {
            if (input.Length == 1) { return input; }

            int mid = input.Length / 2;
            var left= DoMergeSort(input[..mid]);
            var right = DoMergeSort(input[mid..]);
            int[] result=new int[(left.Length+right.Length)];
            int idxLeft=0, idxRight=0,idxResult=0;
            while (idxLeft < left.Length && idxRight < right.Length)
            {
                result[idxResult++]= left[idxLeft]<right[idxRight]? left[idxLeft++]:right[idxRight++];
            }
            if (idxLeft==left.Length) 
            { Array.Copy(right,idxRight, result,idxResult,result.Length - idxResult); }//left side is done
            if (idxRight == right.Length) 
            { Array.Copy(left, idxLeft, result, idxResult, result.Length - idxResult); }//right side is done
            return result;
        }
    }
}

