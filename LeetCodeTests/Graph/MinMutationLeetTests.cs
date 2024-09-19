using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.Tests
{
    [TestClass()]
    public class MinMutationLeetTests
    {
        [TestMethod()]
        public void MinMutationTest()
        {
            string startGene = "AACCGGTT", endGene = "AAACGGTA";
            string[] bank = ["AACCGGTA", "AACCGCTA", "AAACGGTA"];
            int expected = 2;
            int actual = new MinMutationLeet().MinMutation(startGene, endGene, bank);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MinMutationTest2()
        {
            string startGene = "AACCGGTT", endGene = "AAACGGTA";
            string[] bank = ["AACCGGTA", "AACCGCTA", "AAACGGTA"];
            int expected = 2;
            int actual = new MinMutationLeet().MinMutation2(startGene, endGene, bank);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MinMutationTest3()
        {
            string startGene = "AACCGGTT", endGene = "AACCGCTA";
            string[] bank = ["AACCGGTA", "AACCGCTA", "AAACGGTA"];
            int expected = 2;
            int actual = new MinMutationLeet().MinMutation2(startGene, endGene, bank);
            Assert.AreEqual(expected, actual);
        }
    }
}