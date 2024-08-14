using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
    public class RemoveDuplicateII
    {
        public int RemoveDuplicates(int[] nums)
        {
            int counter = 0;
            bool hasAppearedTwoTimes=false;

            for (int i = 1; i < nums.Length; i++) { 
            bool isRepeat = (nums[counter] == nums[i]);
                if (!isRepeat || !hasAppearedTwoTimes)
                {
                    nums[++counter] = nums[i];
                }
                hasAppearedTwoTimes = isRepeat;
            }

            return counter+1;
        }
    }
}
