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
        public int MaxArea2(int[] height) //cartesian product wont pass the Time Limit Exceeded test cases :)
        {
            var heightWithIndex =height.Select((x, idx) => new { index = idx, height = x });
            var q = from x in heightWithIndex 
                    join y in heightWithIndex on 1 equals 1
                    select new { volume = (x.index - y.index) * Math.Min(x.height, y.height) };

            return q.Max(r=>r.volume);
        }
        public int MaxArea3(int[] height) //cartesian product wont pass the Time Limit Exceeded test cases :)
        {
            var heightWithIndex = height.Select((x, idx) => new { index = idx, height = x });
            var q = from x in heightWithIndex
                    from y in heightWithIndex
                    where (x.index != y.index)
                    select new { volume = (x.index - y.index) * Math.Min(x.height, y.height) };

            return q.Max(r => r.volume);
        }
    }
}
