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
        [TestMethod()]
        public void AnagramTest3()
        {
            string s = "戰爭持續拖長", t = "持續戰爭長拖";
            bool expected = true;
            bool actual = new Anagram().IsAnagram(s, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AnagramTest4()
        {
            string s = "戰爭持續拖長", t = "持續戰爭長拖長長";
            bool expected = false;
            bool actual = new Anagram().IsAnagram(s, t);
            Assert.AreEqual(expected, actual);
        }
    }
}