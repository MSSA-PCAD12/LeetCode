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
        public IList<string> SummaryRanges2(int[] nums)//for LOLs
        {
            List<int> gaps = new();
            List<string> result = new();
            gaps.Add(0);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1 || (long)nums[i + 1] - (long)nums[i] > 1) gaps.Add(i + 1);
            }
            for (int i = 0; i < gaps.Count() - 1; i++)
            {
                if (nums[gaps[i]..gaps[i + 1]].Length == 1) result.Add(nums[gaps[i]..gaps[i + 1]][0].ToString());
                else
                    result.Add($"{nums[gaps[i]..gaps[i + 1]][0]}->{nums[gaps[i]..gaps[i + 1]][^1]}");
            }
            return result;
        }
        public IList<string> SummaryRanges3(int[] nums)
        {
            return nums
                .Select((x, y) => new { Rank = x - y, Value = x })
                .GroupBy(x => x.Rank)
                .Select(x => new { Min = x.Min(y => y.Value), Max = x.Max(y => y.Value) })
                .Select(x => x.Min == x.Max ? $"{x.Min}" : $"{x.Min}->{x.Max}")
                .ToList();
        }
    }
}

