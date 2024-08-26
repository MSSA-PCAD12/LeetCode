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
    public class AddOneTests
    {
        [TestMethod()]
        public void PlusOneTest()
        {
            int[] input =[1, 2, 3];
            int[] expected = [1, 2, 4];
            int[] actual = new AddOne().PlusOne(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PlusOneTest2()
        {
            int[] input = [4, 3, 2, 1];
            int[] expected = [4, 3, 2, 2];
            int[] actual = new AddOne().PlusOne(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PlusOneTest3()
        {
            int[] input = [9];
            int[] expected = [1,0];
            int[] actual = new AddOne().PlusOne(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PlusOneTest4()
        {
            int[] input = [9,9,9,9];
            int[] expected = [1, 0,0,0,0];
            int[] actual = new AddOne().PlusOne(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}