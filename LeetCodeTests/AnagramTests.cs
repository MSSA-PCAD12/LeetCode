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
    public class AnagramTests
    {
        [TestMethod()]
        public void AnagramTest1()
        {
            string s = "anagram", t = "nagaram";
            bool expected = true;
            bool actual = new Anagram().IsAnagram(s, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AnagramTest2()
        {
            string s = "rat", t = "car";
            bool expected = false;
            bool actual = new Anagram().IsAnagram(s, t);
            Assert.AreEqual(expected, actual);
        }
    }
}