using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/is-subsequence/
    public class IsSubsequenceLeet
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length==0) return true;
            if (t.Length == 0) return false;
            int sPointer=0,tPointer=0;

            while (sPointer < s.Length) {

                while (tPointer < t.Length)
                {
                    if (t[tPointer] == s[sPointer])
                    {
                        sPointer++;
                        if (sPointer == s.Length) return true;
                    }
            
                    tPointer++;
                    if (tPointer == t.Length) return false;
                }
            }
            return true;
        }
    }
}
