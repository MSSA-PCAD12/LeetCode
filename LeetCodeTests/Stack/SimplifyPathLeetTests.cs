using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeetCode.Stack.Tests
{
    [TestClass()]
    public class SimplifyPathLeetTests
    {
        [TestMethod()]
        public void SimplifyPathTest()
        {
            string path = "/home/user/Documents/../Pictures";
            string actual = new SimplifyPathLeet().SimplifyPath(path);
            string expected = "/home/user/Pictures";
            Assert.AreEqual(expected, actual);
        }
    }
}