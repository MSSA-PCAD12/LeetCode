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
    public class ZigzagStringTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            string input = "PAYPALISHIRING";
            int numRows = 4;
            string expected = "PINALSIGYAHRPI";
            string actual = new ZigzagString().Convert(input, numRows);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ConvertTest2()
        {
            string input = "PAYPALISHIRING";
            int numRows = 3;
            string expected = "PAHNAPLSIIGYIR";
            string actual = new ZigzagString().Convert(input, numRows);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ConvertTest3()
        {
            string input = "A";
            int numRows = 1;
            string expected = "A";
            string actual = new ZigzagString().Convert(input, numRows);
            Assert.AreEqual(expected, actual);
        }
    }
}