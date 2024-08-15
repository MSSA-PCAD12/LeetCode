using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class WordPatternTests
    {
        [TestMethod()]
        public void WordPatternTest()
        {
            string pattern = "abba", s = "dog cat cat dog";
            bool expected = true;
            WordPatternLeet w = new();
            bool actual = w.WordPattern(pattern, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void WordPatternTest2()
        {
            string pattern = "abba", s = "dog cat cat fish";
            bool expected = false;
            WordPatternLeet w = new();
            bool actual = w.WordPattern(pattern, s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WordPatternTest4()
        {
            string pattern = "abba", s = "dog dog dog dog";
            bool expected = false;
            WordPatternLeet w = new();
            bool actual = w.WordPattern(pattern, s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WordPatternTest3()
        {
            string pattern = "aaaa", s = "dog cat cat dog";
            bool expected = false;
            WordPatternLeet w = new();
            bool actual = w.WordPattern(pattern, s);
            Assert.AreEqual(expected, actual);
        }

    }
}