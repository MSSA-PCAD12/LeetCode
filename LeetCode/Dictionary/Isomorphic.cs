using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/isomorphic-strings/
    public class Isomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length!=t.Length) return false;
            SortedList<char,char> sToT = new();
            SortedList<char, char> tToS = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (sToT.TryGetValue(s[i],out char sChar) && tToS.TryGetValue(t[i],out char tChar)
                    && sChar== t[i]  && tChar == s[i]
                    )
                {
                    continue;
                }
                else
                {
                    if (sToT.ContainsKey(s[i]) && sToT[s[i]] != t[i]
                        ||
                       tToS.ContainsKey(t[i]) && tToS[t[i]] != s[i]
                        ) return false;

                    sToT.Add(s[i], t[i]);
                    tToS.Add(t[i], s[i]);
                }
            }
            
            
            return true;
        }
    }
}
