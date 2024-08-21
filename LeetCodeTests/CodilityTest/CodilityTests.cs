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
    public class CodilityTest
    {
        [TestMethod()]
        public void CodilityTest1()
        {
            var expected = "centipede";
            var actual = new codility().getNote("cdeenetpi", [5, 2, 0, 1, 6, 4, 8, 3, 7]);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CodilityTest2()
        {
            var expected = "bat";
            var actual = new codility().getNote("bytdag", [4, 3, 0, 1, 2, 5]);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CodilityTest3()
        {
            var expected = "code";
            var actual = new codility().getNote("cdeo", [3, 2, 0, 1]);
            Assert.AreEqual(expected, actual);
        }
    }
}