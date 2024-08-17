using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	//https://leetcode.com/problems/isomorphic-strings/
	public class Anagram
	{
		public bool IsAnagram(string s, string t) {
			Dictionary<char,int> map = new Dictionary<char,int>();
			foreach (char c in s)
			{
				if (map.TryGetValue(c, out _)) 
					map[c] += 1; 
				else map.Add(c, 1);
			}
            foreach (char c in t)
            {
				int charCount = 0;
				if (map.TryGetValue(c, out charCount))
				{
					map[c]=--charCount;
					if (charCount == 0) { map.Remove(c); }
				}
				else
				{
					return false;
				}
            }

            return map.Count==0;
		}
	}
}
