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
    public class SearchInsertPositionTests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 5;
            int expected = 2;
            int actual=  new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SearchInsertTest2()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 2;
            int expected = 1;
            int actual = new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SearchInsertTest3()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 7;
            int expected = 4;
            int actual = new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SearchInsertTest4()
        {
            int[] nums = [1,2, 3, 5, 6,7,8,9];
            int target = 4;
            int expected = 3;
            int actual = new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SearchInsertTest5()
        {
            int[] nums = [1];
            int target = 2;
            int expected = 1;
            int actual = new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SearchInsertTest6()
        {
            int[] nums = [1,3];
            int target = 1;
            int expected = 0;
            int actual = new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SearchInsertTest7()
        {
            int[] nums = [1, 3];
            int target = 3;
            int expected = 1;
            int actual = new SearchInsertPosition().SearchInsert(nums, target);
            Assert.AreEqual(expected, actual);
        }

    }
}