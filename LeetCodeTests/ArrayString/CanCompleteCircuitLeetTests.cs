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
    public class CanCompleteCircuitLeetTests
    {
        [TestMethod()]
        public void CanCompleteCircuitTest()
        {
            int[] gas = [5, 1, 2, 3, 4];
            int[] cost = [4, 4, 1, 5, 1];
            int expected = 4;
            int actual = new CanCompleteCircuitLeet().CanCompleteCircuit(gas, cost);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CanCompleteCircuitTest2()
        {
            int[] gas = [5, 1, 2, 3, 4];
            int[] cost = [4, 4, 1, 5, 1];
            int expected = 4;
            int actual = new CanCompleteCircuitLeet().CanCompleteCircuit(gas, cost);
            Assert.AreEqual(expected, actual);
        }
    }
}