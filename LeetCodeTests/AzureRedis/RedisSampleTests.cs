using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.AzureRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AzureRedis.Tests
{
    [TestClass()]
    public class RedisSampleTests
    {
        [TestMethod()]
        public void AddToSetTest()
        {
            new RedisSample().AddToSet("Victor", "Hello World");
        }
        [TestMethod()]
        public void GetFromSetTest()
        {
            string actual = new RedisSample().GetValueFromSet("Victor");
            string expected = "Hello World";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetContainsTest()
        {
            bool actual = new RedisSample().SetContains("Victor", "Hello World");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}