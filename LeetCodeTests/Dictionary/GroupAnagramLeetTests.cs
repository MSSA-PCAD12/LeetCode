using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode.Dictionary.Tests
{
    [TestClass]
    public class GroupAnagramLeetTests
    {
        private GroupAnagramLeet groupAnagramLeet;

        [TestInitialize]
        public void Initialize()
        {
            // Initialize your GroupAnagramLeet instance here (if needed)
            groupAnagramLeet = new GroupAnagramLeet();
        }

        [TestMethod]
        public void GroupAnagrams_ValidInput_ReturnsCorrectGroups()
        {
            // Arrange
            string[] strs = new string[]
            {
            "eat", "tea", "tan", "ate", "nat", "bat"
            };

            // Act
            List<string>[] actual = groupAnagramLeet.GroupAnagrams(strs);

            // Assert
            // Verify that the anagrams are correctly grouped
            // Example: Assert.AreEqual(3, result.Count);
            // Add more assertions as needed
            List<string>[] expected = [["bat"], ["nat", "tan"], ["ate", "eat", "tea"]];
            CollectionAssert.AreEquivalent(expected[0], actual[0]);
            CollectionAssert.AreEquivalent(expected[1], actual[1]);
            CollectionAssert.AreEquivalent(expected[2], actual[2]);

        }

        [TestMethod]
        public void GroupAnagrams_ValidInput_ReturnsCorrectGroups2()
        {
            // Arrange
            string[] strs = new string[]
            {
            "cab","tin","pew","duh","may","ill","buy","bar","max","doc"
            };

            // Act
            List<string>[] actual = groupAnagramLeet.GroupAnagrams(strs);

            // Assert
            // Verify that the anagrams are correctly grouped
            // Example: Assert.AreEqual(3, result.Count);
            // Add more assertions as needed
            //List<string>[] expected = [["max"], ["buy"], ["doc"], ["may"], ["ill"], ["duh"], ["tin"], ["bar"], ["pew"], ["cab"]];
            Assert.AreEqual(10, actual.Count());
            

        }

        // Add more test methods for other scenarios (e.g., edge cases, different input arrays, etc.)
    }
}