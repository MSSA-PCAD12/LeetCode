using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class ClimbStairsLeetTests
    {
        [TestMethod()]
        public void ClimbStairsTest()
        {
            int input = 2;
            int expected = 2;
            int actual = new ClimbStairsLeet().ClimbStairs(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ClimbStairsTest2()
        {
            int input = 3;
            int expected = 3;
            int actual = new ClimbStairsLeet().ClimbStairs(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ClimbStairsTest3()
        {
            int input = 4;
            int expected = 5;
            int actual = new ClimbStairsLeet().ClimbStairs(input);
            Assert.AreEqual(expected, actual);
        }
    }
}