using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    //https://leetcode.com/problems/minimum-size-subarray-sum/
    public class MinSizeSubArraySum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {   if (nums.Length == 0) return 0;
            int start = 0;
            int end = 0;
            int w_sum = nums[0];
            int minLength = int.MaxValue;
            while (end < nums.Length)
            {
                if (w_sum < target)
                {
                    end++;
                    if (end < nums.Length)
                        w_sum += nums[end];
                }
                else
                {
                    minLength = Math.Min(minLength, end - start + 1);
                    w_sum -= nums[start];
                    start++;
                }
            }
            return minLength == int.MaxValue ? 0 : minLength;
        }
    }

}
