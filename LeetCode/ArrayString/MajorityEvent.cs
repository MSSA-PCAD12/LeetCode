using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/merge-sorted-array
    public class MajorityEvent
    {
        public int MajorityElement(int[] nums)
        {
            int currentValue = 0, count = 0;
            foreach (int i in nums)
            {
                if (count == 0)
                {
                    currentValue = i;
                }
                if (currentValue == i)
                { 
                    count++; 
                }
                else 
                { 
                    count--; 
                }
            }

            return currentValue;
        }
    }
}
