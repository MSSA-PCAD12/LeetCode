using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveElementLeet
    {
        public int RemoveElement(int[] nums, int val)
        {
            int countOfNotVal = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != val) {
                    nums[countOfNotVal] = nums[i];
                    countOfNotVal++;
                }
            }
            return countOfNotVal;
        }
    }
}
