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
    public class IsHappyLeetTests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            int input = 19;
            bool expected = true;
            var actual = new IsHappyLeet().IsHappy(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsHappyTest2()
        {
            int input = 2;
            bool expected = false;
            var actual = new IsHappyLeet().IsHappy(input);
            Assert.AreEqual(expected, actual);
        }
    }
}