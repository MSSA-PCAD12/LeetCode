using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.ArrayString;

namespace LeetCode.ArrayString.Tests
{
    [TestClass()]
    public class ProductOfArrayExceptSelfLeetTests
    {
        [TestMethod()]
        public void ProductExceptSelfTest()
        {
            int[] input = [1, 2, 3, 4];
            int[] expected= [24, 12, 8, 6];
            var actual = new ProductOfArrayExceptSelfLeet().ProductExceptSelf(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ProductExceptSelfTest2()
        {
            int[] input = [-1, 1, 0, -3, 3];
            int[] expected = [0, 0, 9, 0, 0];
            var actual = new ProductOfArrayExceptSelfLeet().ProductExceptSelf(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        
    }
}