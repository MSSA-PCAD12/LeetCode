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
    public class IsomorphicTests
    {
        [TestMethod()]
        public void IsIsomorphicTest()
        {
            string s = "egg", t = "add";
            bool expected = true;
            Isomorphic i = new Isomorphic();
            var actual =i.IsIsomorphic(s,t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsIsomorphicTest2()
        {
            string s = s = "foo", t = "bar";
            bool expected = false;
            Isomorphic i = new Isomorphic();
            var actual = i.IsIsomorphic(s, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsIsomorphicTest3()
        {
            string s = "paper", t = "title";
            bool expected = true;
            Isomorphic i = new Isomorphic();
            var actual = i.IsIsomorphic(s, t);
            Assert.AreEqual(expected, actual);
        }
    }
}