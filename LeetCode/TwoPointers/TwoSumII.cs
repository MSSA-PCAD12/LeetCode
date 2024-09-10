using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.TwoPointers
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {

            int leftPointer = 0;
            int rightPointer = numbers.Length - 1;
            while (leftPointer < rightPointer)
            {
                if (numbers[leftPointer] + numbers[rightPointer] > target)
                {
                    rightPointer--;
                }
                else if (numbers[leftPointer] + numbers[rightPointer] < target)
                {
                    leftPointer++;
                }
                else
                {
                    return [leftPointer + 1, rightPointer + 1];
                }
            }
            return [-1, -1];
        }


        public int[] TwoSum2(int[] numbers, int target) { 
            int leftPointer = 0;
            int rightPointer = 1;
            return GetTarget(leftPointer,rightPointer,numbers,target);
        }

        private int[] GetTarget(int leftPointer, int rightPointer, int[] numbers, int target)
        {
            if (numbers[leftPointer] + numbers[rightPointer] == target) return [leftPointer+1, rightPointer+1];
            else {
                if (rightPointer == numbers.Length - 1) { leftPointer += 1; rightPointer= leftPointer+1;}
            }
            return GetTarget(leftPointer, ++rightPointer, numbers,target);

        }

        public int[] TwoSum3(int[] numbers, int target)
        {
            var q = from x in numbers
                    join y in numbers 
                    on target-x equals y 
                    select new int[] { Array.IndexOf(numbers,x) +1, Array.LastIndexOf(numbers, y) + 1 };
            return q.ToArray().First();
        }
    }
}
