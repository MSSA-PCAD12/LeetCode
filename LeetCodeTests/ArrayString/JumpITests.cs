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
    public class JumpITests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            int[] nums = [2, 3, 1, 1, 4];
            bool expect = true;
            bool actual = new JumpI().CanJump(nums);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void CanJumpTest2()
        {
            int[] nums = [3, 2, 1, 0, 4];
            bool expect = false;
            bool actual = new JumpI().CanJump(nums);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void CanJumpTest3()
        {
            int[] nums = [0];
            bool expect = true;
            bool actual = new JumpI().CanJump(nums);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void CanJumpTest4()
        {
            int[] nums = [1];
            bool expect = true;
            bool actual = new JumpI().CanJump(nums);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void CanJumpTest5()
        {
            int[] nums = [2,0];
            bool expect = true;
            bool actual = new JumpI().CanJump(nums);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void CanJumpTest6()
        {
            int[] nums = [5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0];
            bool expect = true;
            bool actual = new JumpI().CanJump(nums);
            Assert.AreEqual(expect, actual);
        }
    }
}