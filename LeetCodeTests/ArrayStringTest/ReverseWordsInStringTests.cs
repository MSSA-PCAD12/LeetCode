using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString.Tests
{
    [TestClass()]
    public class ReverseWordsInStringTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            string input = "the sky is blue";
            string expected = "blue is sky the";
            string actual = new ReverseWordsInString().ReverseWords(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ReverseWordsTest2()
        {
            string input = "  hello world  ";
            string expected = "world hello";
            string actual = new ReverseWordsInString().ReverseWords(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ReverseWordsTest3()
        {
            string input = "a good   example";
            string expected = "example good a";
            string actual = new ReverseWordsInString().ReverseWords(input);
            Assert.AreEqual(expected, actual);
        }
    }
}