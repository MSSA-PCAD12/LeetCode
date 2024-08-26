using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    //https://leetcode.com/problems/jump-game/
    public class JumpI
    {
        public bool CanJump(int[] nums)
        {
            int maxJump = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i>maxJump) return false;
                maxJump = Math.Max(maxJump,nums[i]+i);
                if (maxJump >= nums.Length - 1) { return true; }
            }
            return false;
            //return DoesNotWork(nums);

        }

        private static bool DoesNotWork(int[] nums)
        {
            int currentPosition = 0;
            if (currentPosition == nums.Length - 1) return true;
            while (nums[currentPosition] != 0)
            {
                int range = nums[currentPosition];
                if (currentPosition + range + 1 > nums.Length - 1) return true;
                var movementList = nums[(currentPosition + 1)..(currentPosition + range + 1)];
                currentPosition += movementList.Select((x, y) => x + y).Max() + 1;
                if (currentPosition >= nums.Length - 1) { return true; }
            }
            if (currentPosition == nums.Length - 1) return true;
            return false;
        }
    }
}
