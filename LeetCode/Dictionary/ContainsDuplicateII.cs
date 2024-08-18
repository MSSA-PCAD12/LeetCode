using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/contains-duplicate-ii
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (k == 0) return false;
            HashSet<int> set = new(k);
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.TryGetValue(nums[i], out _)) return true;
                else
                {
                    if (i >= k)
                    { set.Remove(nums[i - k]); }

                    set.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
