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
    public class MergeSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
        
            System.Random rnd = new System.Random();
            var input = Enumerable.Range(1, 10).OrderBy(x => rnd.Next(10)).ToArray();
            var actual =  new MergeSort().DoMergeSort(input);
            Array.Sort(input);
            var expected = input;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SortTest2()
        {

            System.Random rnd = new System.Random();
            var input = Enumerable.Range(1, 999).OrderBy(x => rnd.Next(1000)).ToArray();
            var actual = new MergeSort().DoMergeSort(input);
            Array.Sort(input);
            var expected = input;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SortTest3()
        {

            System.Random rnd = new System.Random();
            var input = Enumerable.Range(1, 9999).OrderBy(x => rnd.Next(10000)).ToArray();
            var actual = new MergeSort().DoMergeSort(input);
            Array.Sort(input);
            var expected = input;
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}