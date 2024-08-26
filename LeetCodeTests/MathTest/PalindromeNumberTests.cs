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
    public class PalindromeNumberTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            var input = 121;
            bool expected=true;
            bool actual = new PalindromeNumber().IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsPalindromeTest2()
        {
            var input = -121;
            bool expected = false;
            bool actual = new PalindromeNumber().IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsPalindromeTest3()
        {
            var input = 10;
            bool expected = false;
            bool actual = new PalindromeNumber().IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsPalindromeTest4()
        {
            var input = 1;
            bool expected = true;
            bool actual = new PalindromeNumber().IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsPalindromeTest5()
        {
            var input = 135797531;
            bool expected = true;
            bool actual = new PalindromeNumber().IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}