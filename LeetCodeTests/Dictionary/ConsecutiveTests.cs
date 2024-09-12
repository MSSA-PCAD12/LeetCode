using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Dictionary.Tests
{
    [TestClass()]
    public class ConsecutiveTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
            int actual = new Consecutive().LongestConsecutive(nums);
            int expected = 9;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestConsecutiveTest2()
        {
            int[] nums = nums = [100, 4, 200, 1, 3, 2];
            int actual = new Consecutive().LongestConsecutive(nums);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestConsecutiveTest3()
        { 
            int[] nums = nums = nums =[1, 2, 0, 1];
            int actual = new Consecutive().LongestConsecutive2(nums);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestConsecutiveTest4()
        {
            int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
            int actual = new Consecutive().LongestConsecutive2(nums);
            int expected = 9;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestConsecutiveTest5()
        {
            int[] nums = nums = [100, 4, 200, 1, 3, 2];
            int actual = new Consecutive().LongestConsecutive2(nums);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestConsecutiveTest6()
        {
            int[] nums = nums = nums = [1, 2, 0, 1];
            int actual = new Consecutive().LongestConsecutive(nums);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}