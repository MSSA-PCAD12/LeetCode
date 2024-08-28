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
    public class IntToRomanLeetTests
    {
        [TestMethod()]
        public void IntToRomanTest()
        {
            int input = 3749;
            string expected = "MMMDCCXLIX";
            string actual = new IntToRomanLeet().IntToRoman(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IntToRomanTest2()
        {
            int input = 58;
            string expected = "LVIII";
            string actual = new IntToRomanLeet().IntToRoman(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IntToRomanTest3()
        {
            int input = 1994;
            string expected = "MCMXCIV";
            string actual = new IntToRomanLeet().IntToRoman(input);
            Assert.AreEqual(expected, actual);
        }
    }
}