using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class ThreeSumLeet
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            if (nums.Length <= 2) return result;

            Array.Sort(nums);
            

            int start = 0;
            int left = 1;
            int right = nums.Length - 1;
            while (start < nums.Length - 2)
            {
                right = nums.Length - 1;
                left = start + 1;
                while (right > left)
                {
                    if (nums[start] + nums[left] + nums[right] >0)
                    {
                        right--;
                    }
                    else if (nums[start] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else { 
                        result.Add(new List<int>() { nums[start] , nums[left] , nums[right] });

                        int currLeft = nums[left];
                        int currRight = nums[right];
                        while (left < right && nums[left] == currLeft)
                            ++left;
                        while (left < right && nums[right] == currRight)
                            --right;
                    }

                }
                int currentStartNumber = nums[start];
                while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                    ++start;
            }   
            return result;
        }
    }
}
