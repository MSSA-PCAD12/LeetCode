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
    public class ValidParenthesisTests
    {
        [TestMethod()]
        public void ValidParenthesisTests1() {
            string input = "()";
            bool expected = true;
            bool actual = new ValidParenthesis().IsValid(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidParenthesisTests2()
        {
            string input = "()[]{}";
            bool expected = true;
            bool actual = new ValidParenthesis().IsValid(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidParenthesisTests3()
        {
            string input = "(]";
            bool expected = false;
            bool actual = new ValidParenthesis().IsValid(input);
            Assert.AreEqual(expected, actual);
        }
    }
}