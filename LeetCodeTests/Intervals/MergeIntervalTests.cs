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
    public class MergeIntervalTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];
            int[][] expected = [[1, 6], [8, 10], [15, 18]];
            var actual = new MergeInterval().Merge(intervals);
            for (int i = 0; i < expected.Length; i++) { 
            CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }


        [TestMethod()]
        public void MergeTest3()
        {
            int[][] intervals = [[1, 4], [0, 4]];
            int[][] expected = [[0, 4]];
            var actual = new MergeInterval().Merge(intervals);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void MergeTest2()
        {
            int[][] intervals = [[1, 4], [4, 5]];
            int[][] expected = [[1, 5]];
            var actual = new MergeInterval().Merge(intervals);
            for (int i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}