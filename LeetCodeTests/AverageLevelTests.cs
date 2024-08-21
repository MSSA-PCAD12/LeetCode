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
    public class AverageLevelTests
    {
        [TestMethod()]
        public void AverageOfLevelsTest()
        {
            var root = BinaryTreeHelper.BuildTree([3, 9, 20, null, null, 15, 7]);
            var expected =new List<double> { 3.00000, 14.50000, 11.00000};
            var actual = new AverageLevel().AverageOfLevels(root!) as List<double>;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AverageOfLevelsTest2()
        {
            var root = BinaryTreeHelper.BuildTree([3, 9, 20, 15, 7]);
            var expected = new List<double>{ 3.00000, 14.50000, 11.00000 };
            var actual = new AverageLevel().AverageOfLevels(root!) as List<double> ;
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}