using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtrack
{//https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    public class LetterCombinationsLeet
    {
        Dictionary<char, List<char>> lookup = new Dictionary<char, List<char>>()
        {
            { '2', [ 'a', 'b', 'c'] },
            { '3', [ 'd', 'e', 'f'] },
            { '4', [ 'g', 'h', 'i'] },
            { '5', [ 'j', 'k', 'l'] },
            { '6', [ 'm', 'n', 'o'] },
            { '7', [ 'p', 'q', 'r','s'] },
            { '8', [ 't', 'u', 'v'] },
            { '9', [ 'w', 'x', 'y','z'] },
        };

        public List<string> LetterCombinations(string digits)
        {
            if (digits==string.Empty) return new List<string>();
            List<string> res = new List<string>();
            return GetLetterCombo(0, digits, res);
        }

        private List<string> GetLetterCombo(int v, string digits, List<string> res)
        {            
            if (v > digits.Length - 1) return res;
            List<string> newCombo = new();
            if (res.Count == 0)
            {
                foreach (char c in lookup[digits[v]])
                {
                    newCombo.Add(c.ToString());
                }
            }
            else {
                foreach (string s in res)
                {
                    foreach (char c in lookup[digits[v]])
                    {
                        newCombo.Add(s + c);
                    }
                }
            }
            return GetLetterCombo(v+1,digits,newCombo);
        }

        
    }
}
