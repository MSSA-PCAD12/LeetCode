using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/valid-palindrome/
    public class Palendrome
    {
        public bool IsPalindrome(string s)
        {
            int leftPointer = 0;
            int rightPointer = s.Length - 1;

            while (leftPointer < rightPointer)
            {
                while (!(char.IsLetterOrDigit(s[leftPointer]) && char.IsLetterOrDigit(s[rightPointer])))
                {
                    leftPointer = char.IsLetterOrDigit(s[leftPointer]) ? leftPointer : ++leftPointer;
                    rightPointer = char.IsLetterOrDigit(s[rightPointer]) ? rightPointer : --rightPointer;
                    if (leftPointer >= s.Length - 1 || rightPointer <= 0) { return true; }
                }
                if (char.ToLower(s[leftPointer]) == char.ToLower(s[rightPointer]))
                {
                    leftPointer++;
                    rightPointer--;
                }
                else
                { 
                    return false; 
                }

            }
            return true;
        }
    }
}
