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
    public class CountOf1BitTests
    {
        [TestMethod()]
        public void HammingWeightTest()
        {
            int n = 11;
            int expected = 3;
            var actual = new CountOf1Bit().HammingWeight(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void HammingWeightTest2()
        {
            int n = 128;
            int expected = 1;
            var actual = new CountOf1Bit().HammingWeight(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void HammingWeightTest3()
        {
            int n = 2147483645;
            int expected = 30;
            var actual = new CountOf1Bit().HammingWeight(n);
            Assert.AreEqual(expected, actual);
        }
    }
}