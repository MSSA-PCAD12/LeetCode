using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
    public class FindIndexOfFirstOccurence
    {
        public int StrStr(string haystack, string needle) {
            for (int i = 0; i < haystack.Length - needle.Length; i++) {
                if (haystack[i..(i + needle.Length)] == needle) { return i; }
            }
            return -1;
        }
    }
}
