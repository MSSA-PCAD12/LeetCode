using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class Container
    {
        public int MaxArea(int[] height)
        {
            if (height == null || height.Length == 0) return 0;
            int left = 0;
            int right = height.Length - 1;
            int maxArea = -1;
            while (left < right)
            {
                int area = 0;
                if (height[left] > height[right])
                {
                    area = (right - left) * height[right];
                    right -= 1;
                }
                else
                {
                    area = (right - left) * height[left];
                    left += 1;
                }
                maxArea = Math.Max(maxArea, area);
            }
            return maxArea;
        }
    }
}
