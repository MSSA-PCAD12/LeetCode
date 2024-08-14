using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/roman-to-integer/
    public class RomanNumeral
    {
        public int RomanToInt(string s)
        {
            int result=0;
            Dictionary<string, int> lookup = new Dictionary<string, int>() {
            { "I",1 },
            { "V",5 },
            { "X",10 },
            { "L",50 },
            { "C",100 },
            { "D",500 },
            { "M",1000 },
            { "IV",4 },
            { "IX",9 },
            { "XL",40 },
            { "XC",90 },
            { "CD",400 },
            { "CM",900 }
            };
            for (int i = 0; i < s.Length; i++)
                if (i + 1 < s.Length)
                {
                    if (lookup.ContainsKey(string.Concat(s[i], s[i + 1])))
                    {
                        result += lookup[string.Concat(s[i], s[i + 1])];
                        i += 1;
                        continue;
                    }
                    result += lookup[s[i].ToString()];
                }
                else
                { result += lookup[s[i].ToString()]; }
            return result;
        }
    }
}
