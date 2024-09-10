using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Kadane
{//https://leetcode.com/problems/maximum-sum-circular-subarray/
    public class CircularSubarraySum
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Find the maximum subarray sum using Kadane's algorithm
            int maxKadane = Kadane(nums);
            //see 53. Maximum Subarray
            // Step 2: Find the maximum subarray sum that includes corner elements
            int totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                totalSum += nums[i];
                nums[i] = -nums[i]; // Invert the array elements
            }

            // Step 3: Find the maximum subarray sum of the inverted array
            int maxInvertedKadane = Kadane(nums);

            // Step 4: Calculate the maximum circular subarray sum
            int maxCircular = totalSum + maxInvertedKadane; // maxInvertedKadane is actually the minimum subarray sum of the original array

            // Step 5: Return the maximum of the two cases
            if (maxCircular == 0)
            {
                return maxKadane; // This handles the case where all numbers are negative
            }
            return Math.Max(maxKadane, maxCircular);
        }

        private int Kadane(int[] nums)
        {
            int currentSubarray = nums[0];
            int maxSubarray = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currentSubarray = Math.Max(nums[i], currentSubarray + nums[i]);
                maxSubarray = Math.Max(maxSubarray, currentSubarray);
            }
            return maxSubarray;
        }
    }

}
