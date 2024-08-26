using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/reverse-bits/
    public class ReverseBitsLeet
    {
        public uint ReverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result = result << 1;
                result += (n % 2);
                n = n >> 1;
            }
            return result;
        }
    }
}
