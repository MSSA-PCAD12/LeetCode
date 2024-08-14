using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{   //https://leetcode.com/problems/merge-sorted-array
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0) { Array.Copy(nums2,nums1,nums2.Length); return; }

            for (int i = nums1.Length - 1; i >= 0; i--) {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    (nums1[i], nums1[m - 1]) = (nums1[m - 1], nums1[i]);
                    m -= 1;
                }
                else
                {
                    (nums1[i], nums2[n - 1]) = (nums2[n - 1], nums1[i]);
                    n -= 1;
                    if (n == 0) break;

                }

            }

        }
    }
}
