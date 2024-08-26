using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{//https://leetcode.com/problems/jump-game-ii
    public class JumpII
    {
        public int Jump(int[] nums)
        {
            int end=0,far = 0,jumps=0;
            for(int i=0;i<nums.Length-1;i++) {
                far = Math.Max(far,nums[i]+i);

            if (i == end) {
                    end = far;
                    jumps++;
                }
                
            }
            return jumps;
            //return DoesNotWork(nums);

        }

    }
}
