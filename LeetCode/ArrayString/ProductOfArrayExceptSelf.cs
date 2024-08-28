using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{//https://leetcode.com/problems/product-of-array-except-self/
    public class ProductOfArrayExceptSelfLeet
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] leftProduct = new int[nums.Length];
            int[] rightProduct = new int[nums.Length];
            leftProduct[0] = 1; rightProduct[^1] = 1;
            int[] res = new int[nums.Length];
            for (int i = 1; i < nums.Length; i++)
            {
                leftProduct[i] = leftProduct[i - 1] * nums[i - 1];
            }
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
            }
           
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = leftProduct[i] * rightProduct[i];
            }
            return res;

        }
        public int[] ProductExceptSelf2(int[] nums)
        {
            var nums2 = nums.ToImmutableArray();
            for (int i = 1; i < nums2.Length-1; i++)
            {
                nums[i] =  nums2[0..(i-1)].Aggregate((prev,curr)=>prev*curr) * nums2[(i+1)..].Aggregate((prev, curr) => prev * curr);
            }
            return nums;
        }
    }
}
