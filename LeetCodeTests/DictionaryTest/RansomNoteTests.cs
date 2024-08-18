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
    public class RansomNoteTests
    {
        [TestMethod()]
        public void CanConstructTest()
        {
            string ransomNote = "a", magazine = "b";
            bool expected=false;
            RansomNote r = new();
            bool actual = r.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CanConstructTest2()
        {
            string ransomNote = "aa", magazine = "ab";
            bool expected = false;
            RansomNote r = new();
            bool actual = r.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CanConstructTest3()
        {
            string ransomNote = "aa", magazine = "aab";
            bool expected = true;
            RansomNote r = new();
            bool actual = r.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CanConstructTest4()
        {
            string ransomNote = "aa", magazine = "aabbbbbzzzzrrrrrdd";
            bool expected = true;
            RansomNote r = new();
            bool actual = r.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(expected, actual);
        }
    }
}