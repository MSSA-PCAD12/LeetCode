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
    public class LengthOfLastWordLeetTests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            var s = "Hello World";
            int expected = 5;
            LengthOfLastWordLeet l = new();
            int actual = l.LengthOfLastWord(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LengthOfLastWordTest2()
        {
            var s = "   fly me   to   the moon  ";
            int expected = 4;
            LengthOfLastWordLeet l = new();
            int actual = l.LengthOfLastWord(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LengthOfLastWordTest3()
        {
            var s = "luffy is still joyboy";
            int expected = 6;
            LengthOfLastWordLeet l = new();
            int actual = l.LengthOfLastWord(s);
            Assert.AreEqual(expected, actual);
        }
    }
}