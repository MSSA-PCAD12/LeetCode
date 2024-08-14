using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass]
    public class RomanNumeralTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            string s = "III";
            RomanNumeral r = new();
            int expected = 3;
            int actual= r.RomanToInt(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RomanToIntTest2()
        {
            string s = "LVIII";
            RomanNumeral r = new();
            int expected = 58;
            int actual = r.RomanToInt(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RomanToIntTest3()
        {
            string s = "MCMXCIV";
            RomanNumeral r = new();
            int expected = 1994;
            int actual = r.RomanToInt(s);
            Assert.AreEqual(expected, actual);
        }
    }
}