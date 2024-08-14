using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{   //https://leetcode.com/problems/longest-common-prefix
    public class LongestPrefix
    {

        public string LongestCommonPrefix(string[] strs)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < strs[0].Length; i++)
            {
                char aLetter = strs[0][i];
                bool toAddThisChar = true;
                foreach (var item in strs)
                {
                    if (i >= item.Length) { toAddThisChar = false; break; }
                    if (aLetter != item[i])
                    {
                        toAddThisChar = false;
                    }
                }
                if (toAddThisChar) { sb.Append(aLetter); } else { break; }

            }
            return sb.ToString();
        }
        public string LongestCommonPrefix2(string[] strs)
        {
            string commonPrefix=string.Empty;
            var shortestWord = strs.OrderBy(s => s.Length).ToArray()[0];
            for (int i = shortestWord.Length; i > 0; i--) {
                if (strs.All(s => s.StartsWith(shortestWord[0..i])))
                {
                    commonPrefix = shortestWord[0..i];
                    break;
                }
            }
            return commonPrefix;
        }
    }
}
