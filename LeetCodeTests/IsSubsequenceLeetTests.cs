using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class IsSubsequenceLeetTests
    {
        [TestMethod()]
        public void IsSubsequenceTest()
        {
            string s = "abc", t = "ahbgdc";
            bool expected = true;
            IsSubsequenceLeet leet = new();
            bool actual= leet.IsSubsequence(s, t);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsSubsequenceTest2()
        {
            string s = "axc ", t = "ahbgdc";
            bool expected = false;
            IsSubsequenceLeet leet = new();
            bool actual = leet.IsSubsequence(s, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsSubsequenceTest3()
        {
            string s = "abc", t = "abcdefghijk";
            bool expected = true;
            IsSubsequenceLeet leet = new();
            bool actual = leet.IsSubsequence(s, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsSubsequenceTest4()
        {
            string s = "acb", t = "ahbgdc";
            bool expected = false;
            IsSubsequenceLeet leet = new();
            bool actual = leet.IsSubsequence(s, t);
            Assert.AreEqual(expected, actual);
        }
    }
}