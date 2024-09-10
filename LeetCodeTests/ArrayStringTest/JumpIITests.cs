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
    public class JumpIITests
    {
        [TestMethod()]
        public void JumpTest()
        {
            int[] nums = [2, 3, 1, 1, 4];
            int expected = 2;
            int actual = new JumpII().Jump(nums);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void JumpTest2()
        {
            int[] nums = [2, 3, 0, 1, 4];
            int expected = 2;
            int actual = new JumpII().Jump(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}