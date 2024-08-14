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
    public class LongestPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            string[] strs = ["flower", "flow", "flight"];
            string expected = "fl";
            LongestPrefix l = new LongestPrefix();
          
            string actual = l.LongestCommonPrefix(strs);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestCommonPrefixTest2()
        {
            string[] strs = ["dog", "racecar", "car"];
            string expected = "";
            LongestPrefix l = new LongestPrefix();

            string actual = l.LongestCommonPrefix(strs);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestCommonPrefixTest3()
        {
            string[] strs = ["flower", "flow", "flowing","flowery"];
            string expected = "flow";
            LongestPrefix l = new LongestPrefix();

            string actual = l.LongestCommonPrefix(strs);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void LongestCommonPrefix2Test()
        {
            string[] strs = ["flower", "flow", "flight"];
            string expected = "fl";
            LongestPrefix l = new LongestPrefix();

            string actual = l.LongestCommonPrefix2(strs);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestCommonPrefix2Test2()
        {
            string[] strs = ["dog", "racecar", "car"];
            string expected = "";
            LongestPrefix l = new LongestPrefix();

            string actual = l.LongestCommonPrefix2(strs);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestCommonPrefix2Test3()
        {
            string[] strs = ["flower", "flow", "flowing", "flowery"];
            string expected = "flow";
            LongestPrefix l = new LongestPrefix();

            string actual = l.LongestCommonPrefix2(strs);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestCommonPrefix2Test4()
        {
            string[] strs = ["flower"];
            string expected = "flower";
            LongestPrefix l = new LongestPrefix();

            string actual = l.LongestCommonPrefix2(strs);
            Assert.AreEqual(expected, actual);
        }
    }
}