using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/valid-parentheses/
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            char[] parens = ['(', ')', '[', ']', '{', '}'];
            Stack<char> stack = new Stack<char>();
            foreach (char c in s) {
                if (Array.IndexOf(parens, c) % 2 == 0) stack.Push(c);
                else
                    if (stack.Count == 0 || stack.Pop() != parens[Array.IndexOf(parens, c) - 1]) return false;
            }
            if (stack.Count == 0) return true;
            else
            return false;
        }
    }
}
