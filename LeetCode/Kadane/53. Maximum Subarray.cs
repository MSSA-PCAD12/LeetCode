using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Kadane
{//https://leetcode.com/problems/maximum-subarray/
    public class MaxSubArrayLeet
    {
        public int MaxSubArray(int[] nums)
        {
            int currentSubarray = nums[0];
            int maxSubarray = nums[0];
            // Start with the 2nd element since we already used the first one.
            for (int i = 1; i < nums.Length; i++)
            {
                // If current_subarray is negative, throw it away. Otherwise, keep
                // adding to it.
                currentSubarray = Math.Max(nums[i], currentSubarray + nums[i]);
                maxSubarray = Math.Max(maxSubarray, currentSubarray);
            }

            return maxSubarray;
        }
    }
}
