using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicate
    {

        //field
        //property
        //events
        //methods
          //ctor
        public int RemoveDuplicates(int[] nums)
        {
            int result = 0, pointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) { result++; continue; }
                if (nums[i] != nums[i - 1])
                {
                    result++;
                    pointer++;
                    nums[pointer] = nums[i];
                }
            }
            return result;
        }
    }
}
