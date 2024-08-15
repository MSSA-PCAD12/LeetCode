using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{   //https://leetcode.com/problems/ransom-note/
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var c in magazine)
            {
                if (!map.ContainsKey(c)) { map.Add(c, 1); }
                else
                    map[c]++;
            }
            //Dictionary<char, int> map = new Dictionary<char, int>(
            //    magazine.GroupBy(letter => letter).Select(g => new KeyValuePair<char, int>(g.Key, g.Count())));

            foreach (char c in ransomNote) {
                if (!map.ContainsKey(c)) return false;
                else map[c] = map[c]-1;
                
                if (map[c]==0) map.Remove(c);
            }
            return true;
        }
    }
}
