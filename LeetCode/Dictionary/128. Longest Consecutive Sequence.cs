using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Dictionary
{
    public class Consecutive
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            nums = nums.Distinct().OrderBy(n=>n).ToArray();
            Array.Sort(nums);

            Dictionary<int, int> group = new();
            for (int i = 0; i < nums.Length; i++) {
                if (group.ContainsKey(i - nums[i]))
                {
                    group[i - nums[i]] += 1;
                }
                else
                {
                    group.Add(i-nums[i], 1);
                }
            
            }
          
            return group.Max(g=>g.Value);
        }


        public int LongestConsecutive2(int[] nums)
        {
            if (nums.Length == 0) return 0;
            HashSet<int> hashset = new HashSet<int>(nums);
            int currentNum = 0;
            int currConsecutive = 0;
            int maxConsecutive = int.MinValue;
            foreach (int i in hashset) {
                currentNum = i;
                if (!hashset.Contains(currentNum - 1))
                {
                    currentNum++;
                    currConsecutive = 1;
                    while (hashset.Contains(currentNum))
                    {
                        currentNum++;
                        currConsecutive++;

                    }
                    maxConsecutive = Math.Max(maxConsecutive, currConsecutive);
                }

                
            }

            return maxConsecutive;
        }
    }
}
