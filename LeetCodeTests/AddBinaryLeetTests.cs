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
    public class AddBinaryLeetTests
    {
        [TestMethod()]
        public void AddBinaryTest()
        {
            string a = "11", b = "1";
            string expected = "100";
            string actual = new AddBinaryLeet().AddBinary(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddBinaryTest2()
        {
            string a = "1010", b = "1011";
            string expected = "10101";
            string actual = new AddBinaryLeet().AddBinary(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddBinaryTest3()
        {
            string a = "11", b = "1";
            string expected = "100";
            string actual = new AddBinaryLeet().AddBinary2(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddBinaryTest4()
        {
            string a = "1010", b = "1011";
            string expected = "10101";
            string actual = new AddBinaryLeet().AddBinary2(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}