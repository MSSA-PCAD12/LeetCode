using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/number-of-1-bits/
    public class CountOf1Bit
    {
        public int HammingWeight(int n)
        {
            int countOf1 = 0;
            while (n > 0)
            {
                countOf1 += n % 2 == 1 ? 1 : 0;
                n /= 2;
            }
            return countOf1;
        }
    }
}
