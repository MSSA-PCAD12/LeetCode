using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow.Tests
{
    [TestClass()]
    public class LongestSubstringWithoutRepeatingTests
    {
        [TestMethod]
        public void TestMixedCharacters()
        {
            var solution = new LongestSubstringWithoutRepeating();
            Assert.AreEqual(3, solution.LengthOfLongestSubstring("pwwkew"));
        }
        [TestMethod]
        public void TestAllSameCharacters()
        {
            var solution = new LongestSubstringWithoutRepeating();
            Assert.AreEqual(1, solution.LengthOfLongestSubstring("aaaaaa"));
        }
        [TestMethod]
        public void TestRepeatingCharacters()
        {
            var solution = new LongestSubstringWithoutRepeating();
            Assert.AreEqual(3, solution.LengthOfLongestSubstring("abcabcbb"));
        }
        [TestMethod]
        public void TestNoRepeatingCharacters()
        {
            var solution = new LongestSubstringWithoutRepeating();
            Assert.AreEqual(6, solution.LengthOfLongestSubstring("abcdef"));
        }
    }
}