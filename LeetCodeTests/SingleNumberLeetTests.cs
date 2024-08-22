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
    public class SingleNumberLeetTests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            var input = new int[] { 2, 2, 1 };
            var expected = 1;
            var actual = new SingleNumberLeet().SingleNumber(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SingleNumberTest2()
        {
            var input = new int[] { 4, 1, 2, 1, 2 };
            var expected = 4;
            var actual = new SingleNumberLeet().SingleNumber(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SingleNumberTest3()
        {
            var input = new int[] { 1,2,3,4,5,2,3,4,5};
            var expected = 1;
            var actual = new SingleNumberLeet().SingleNumber(input);
            Assert.AreEqual(expected, actual);
        }
    }
}