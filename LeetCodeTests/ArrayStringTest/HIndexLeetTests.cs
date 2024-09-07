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
    public class HIndexLeetTests
    {
        [TestMethod()]
        public void HIndexTest()
        {
            int[] citations = [3, 0, 6, 1, 5];
            int expected = 3;
            int actual = new HIndexLeet().HIndex(citations);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void HIndexTest2()
        {
            int[] citations = [1,3,1];
            int expected = 1;
            int actual = new HIndexLeet().HIndex(citations);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void HIndex2Test()
        {
            int[] citations = [3, 0, 6, 1, 5];
            int expected = 3;
            int actual = new HIndexLeet().HIndex2(citations);
            Assert.AreEqual(expected, actual);
        }

    }
}