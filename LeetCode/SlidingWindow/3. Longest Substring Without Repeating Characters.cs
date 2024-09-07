using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    public class LongestSubstringWithoutRepeating
    {
        public int LengthOfLongestSubstring(string s) { 
            if (s == null || s.Length == 0) return 0;
            Dictionary<char, int> map = new();
            int maxLen = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (map.TryGetValue(s[right],out int index)) {
                    left = Math.Max(index, left);
                }
                maxLen=Math.Max(maxLen, right-left+1);
                map[s[right]] = right+1;
            }
            return maxLen;
        }
    }
}
