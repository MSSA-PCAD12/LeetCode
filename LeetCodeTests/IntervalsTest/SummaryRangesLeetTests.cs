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
    public class SummaryRangesLeetTests
    {
        [TestMethod()]
        public void SummaryRangesTest()
        {
            int[] nums = [0, 1, 2, 4, 5, 7];
            var expected = new List<string>() { "0->2", "4->5", "7"};
            var actual = new SummaryRangesLeet().SummaryRanges(nums) as List<string>;
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod()]
        public void SummaryRangesTest2()
        {
            int[] nums = [0, 2, 3, 4, 6, 8, 9];
            var expected = new List<string>() { "0", "2->4", "6", "8->9" };
            var actual = new SummaryRangesLeet().SummaryRanges(nums) as List<string>;
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }

}