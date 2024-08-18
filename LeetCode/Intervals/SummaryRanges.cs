using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{   //https://leetcode.com/problems/contains-duplicate-ii/
    public class SummaryRangesLeet
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();
            if (nums.Length == 0) { return result; }
            int begin = nums[0], end = nums[^1];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] == nums[i] + 1) { end = nums[i]; }
                else
                {
                    end = nums[i];
                    if (begin == end) result.Add(begin.ToString());
                    else { result.Add($"{begin}->{nums[i]}"); }
                    begin = nums[i + 1];
                }
            }
            if (begin == nums[^1]) { result.Add(begin.ToString()); }
            else { result.Add($"{begin}->{nums[^1]}"); }
            return result;
        }
    }
}
