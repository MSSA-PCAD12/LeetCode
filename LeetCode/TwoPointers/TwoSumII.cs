using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
