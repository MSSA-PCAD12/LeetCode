using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class FindIndexOfFirstOccurenceTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            string haystack = "sadbutsad", needle = "sad";
            int expected = 0;
            FindIndexOfFirstOccurence f = new();
            int actual = f.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void StrStrTest2()
        {
            string haystack = "leetcode", needle = "leeto";
            int expected = -1;
            FindIndexOfFirstOccurence f = new();
            int actual = f.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StrStrTest3()
        {
            string haystack = "leetcode", needle = "cod";
            int expected = 4;
            FindIndexOfFirstOccurence f = new();
            int actual = f.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void StrStrTest4()
        {
            string haystack = "leetcodee", needle = "ee";
            int expected = 1;
            FindIndexOfFirstOccurence f = new();
            int actual = f.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void StrStrTest5()
        {
            string haystack = "", needle = "ee";
            int expected = -1;
            FindIndexOfFirstOccurence f = new();
            int actual = f.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }
    }
}