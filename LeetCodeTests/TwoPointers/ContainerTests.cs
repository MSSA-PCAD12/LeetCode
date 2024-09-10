using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers.Tests
{
    [TestClass()]
    public class ContainerTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            int expected = 49;
            int actual = new Container().MaxArea(height);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxAreaTest2()
        {
            int[] height = [1,1];
            int expected = 1;
            int actual = new Container().MaxArea(height);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxAreaTest3()
        {
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            int expected = 49;
            int actual = new Container().MaxArea2(height);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxAreaTest4()
        {
            int[] height = [1, 1];
            int expected = 1;
            int actual = new Container().MaxArea2(height);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxAreaTest5()
        {
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            int expected = 49;
            int actual = new Container().MaxArea3(height);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxAreaTest6()
        {
            int[] height = [1, 1];
            int expected = 1;
            int actual = new Container().MaxArea3(height);
            Assert.AreEqual(expected, actual);
        }
    }
}