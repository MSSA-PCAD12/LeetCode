using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/single-number/
    public class SingleNumberLeet
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int i in nums)
            {
                result = result ^ i;
            }
            return result;
        }
    }
}
