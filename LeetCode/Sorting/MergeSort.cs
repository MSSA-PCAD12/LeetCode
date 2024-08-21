using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSort
    {

        public int[] DoMergeSort(int[] input)
        {
            if (input.Length == 1) {
                return input; }

            int mid = input.Length / 2; //divide input to half
            var left= DoMergeSort(input[..mid]); //send left half
            var right = DoMergeSort(input[mid..]);//send right half
            int[] result=new int[(left.Length+right.Length)]; //initialize result array
            int idxLeft=0, idxRight=0,idxResult=0; //while loop index
            while (idxLeft < left.Length && idxRight < right.Length) //do while both array has elements
            {
                result[idxResult++] = left[idxLeft]<right[idxRight]? left[idxLeft++]:right[idxRight++];
                //pick the smaller number between left and right array and assign it to result
                //increment idxResult index and left or right index
            }
            if (idxLeft == left.Length) //the left side is done
            {
                Array.Copy(
                right, //src array
                idxRight,//src index to start copy
                result, // destination array
                idxResult,// destination array index to start pasting
                result.Length - idxResult);//number of elements to copy
            } //
                            
            //copy the remainder of right and append to unused result elements
            //Array.Copy(src,srcIndex,dest,destIndex,length)
            if (idxRight == right.Length) //the rigth side is done
            { Array.Copy(left, idxLeft, result, idxResult, result.Length - idxResult); }
            
            return result;
        }


        public T[] DoMergeSort<T>(T[] input) where T:IComparable
        {
            if (input.Length == 1) { return input; }

            int mid = input.Length / 2; //divide input to half
            //the following recursion is the divide part
            var left = DoMergeSort(input[..mid]); //send left half
            var right = DoMergeSort(input[mid..]);//send right half

            //the following section runs on return portion of the merge sort
            T[] result = new T[(left.Length + right.Length)]; //initialize result array
            int idxLeft = 0, idxRight = 0, idxResult = 0; //while loop index
            while (idxLeft < left.Length && idxRight < right.Length) //do while both array has elements
            {
                result[idxResult++] = left[idxLeft].CompareTo(right[idxRight])<=0 ? left[idxLeft++] : right[idxRight++];
                //pick the smaller number between left and right array and assign it to result
                //increment idxResult index and left or right index
            }
            if (idxLeft == left.Length) //the left side is done
            {
                Array.Copy(
                right, //src array
                idxRight,//src index to start copy
                result, // destination array
                idxResult,// destination array index to start pasting
                result.Length - idxResult);//number of elements to copy
            } //

            //copy the remainder of right and append to unused result elements
            //Array.Copy(src,srcIndex,dest,destIndex,length)
            if (idxRight == right.Length) //the rigth side is done
            { Array.Copy(left, idxLeft, result, idxResult, result.Length - idxResult); }

            return result;
        }
    }
}

