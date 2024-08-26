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
    public class SqrtTests
    {
        [TestMethod()]
        public void MySqrtTest()
        {
            int input = 4;
            int expected = 2;
            int actual = new Sqrt().MySqrt(input);
            Assert.AreEqual(expected, actual);
          
        }
        [TestMethod()]
        public void MySqrtTest2()
        {
            int input = 8;
            int expected = 2;
            int actual = new Sqrt().MySqrt(input);
            Assert.AreEqual(expected, actual);

        }
    }
}