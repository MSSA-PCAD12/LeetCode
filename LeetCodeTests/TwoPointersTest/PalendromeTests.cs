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
    public class PalendromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            string s = "A man, a plan, a canal: Panama";
            bool expected = true;
            Palendrome p = new();
            bool actual =p.IsPalindrome(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPalindromeTest2()
        {
            string s = "race a car";
            bool expected = false;
            Palendrome p = new();
            bool actual = p.IsPalindrome(s);
            Assert.AreEqual(expected, actual);
        }
    }
}