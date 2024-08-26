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
    public class ReverseBitsLeetTests
    {
        [TestMethod()]
        public void ReverseBitsTest()
        {
            var n = Convert.ToUInt32("00000010100101000001111010011100",2);
            uint expected = 964176192;
            var actual = new ReverseBitsLeet().ReverseBits(n);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ReverseBitsTest2()
        {
            var n = Convert.ToUInt32("11111111111111111111111111111101", 2);
            uint expected = 3221225471;
            var actual = new ReverseBitsLeet().ReverseBits(n);
            Assert.AreEqual(actual, expected);
        }
    }
}