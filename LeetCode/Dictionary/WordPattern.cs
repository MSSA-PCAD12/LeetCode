using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/word-pattern
    public class WordPatternLeet
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split(' ');
            if (pattern.Length!= words.Length) {return false;}

            Dictionary<char, string> map = [];
            for (int i = 0; i < pattern.Length; i++)
            {
                foreach (var item in map)
                {
                    if (item.Value == words[i] && item.Key != pattern[i]) return false;
                }
                if (!map.TryAdd(pattern[i], words[i])
                    && (map.TryGetValue(pattern[i], out string? word) && word != words[i]))
                {
                    return false;
                }
          
            }
            return true;
        }
    }
}
