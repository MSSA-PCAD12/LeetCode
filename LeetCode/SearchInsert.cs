using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/search-insert-position/
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int beginPointer = 0;
            int endPointer = nums.Length-1;
            if (target <= nums[beginPointer]) { return beginPointer - 1 >= 0 ? beginPointer : 0; }
            if (target > nums[endPointer]) { return endPointer + 1; }

            while (beginPointer < endPointer-1) {

                
                int mid = beginPointer + (endPointer - beginPointer) / 2;
                if (nums[mid] == target) return mid;

                if (nums[mid] < target) { beginPointer = mid; }
                if (nums[mid] > target) { endPointer = mid; }
                
            }
            return endPointer;
        }

    }
}

