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
    public class RemoveElementLeetTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = [3, 2, 2, 3];
            int[] expected = [2, 2];
            int val = 3;
            RemoveElementLeet leet = new();
            int k = leet.RemoveElement(nums, val);
            Array.Sort(nums, 0, k);
            Assert.AreEqual( 2,k );

            CollectionAssert.AreEqual(nums[0..k], expected);
        }
        [TestMethod()]
        public void RemoveElementTest2()
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            
            int[] expected = [0, 0, 1, 3, 4];
            int val = 2;
            RemoveElementLeet leet = new();
            int k = leet.RemoveElement(nums, val);
            Array.Sort(nums, 0, k);
            Assert.AreEqual(5, k);

            CollectionAssert.AreEqual(nums[0..k], expected);
        }
    }
}