using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Intervals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Intervals.Tests
{
    [TestClass()]
    public class InsertIntervalTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            int[][] input = [[1, 3], [6, 9]];
            int[] newInterval = [2, 5];
            int[][] expected = [[1, 5], [6, 9]];
            var actual = new InsertInterval().Insert(input, newInterval);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void InsertTest2()
        {
            int[][] input = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
            int[] newInterval = [4, 8];
            int[][] expected = [[1, 2], [3, 10], [12, 16]];
            var actual = new InsertInterval().Insert(input, newInterval);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
        [TestMethod()]
        public void InsertTest3()
        {
            int[][] input = [[1, 3], [6, 9]];
            int[] newInterval = [2, 5];
            int[][] expected = [[1, 5], [6, 9]];
            var actual = new InsertInterval().Insert2(input, newInterval);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void InsertTest4()
        {
            int[][] input = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
            int[] newInterval = [4, 8];
            int[][] expected = [[1, 2], [3, 10], [12, 16]];
            var actual = new InsertInterval().Insert2(input, newInterval);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
        [TestMethod()]
        public void InsertTest5()
        {
            int[][] input = [[1, 5]];
            int[] newInterval = [6, 8];
            int[][] expected = [[1, 5], [6, 8]];
            var actual = new InsertInterval().Insert2(input, newInterval);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}