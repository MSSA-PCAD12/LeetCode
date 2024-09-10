using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Backtrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtrack.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    namespace LetterCombinationsTests
    {
        [TestClass]
        public class LetterCombinationsLeetTests
        {
            [TestMethod]
            public void TestEmptyInput()
            {
                var letterCombinations = new LetterCombinationsLeet();
                var result = letterCombinations.LetterCombinations(string.Empty);
                CollectionAssert.AreEqual(new List<string>(), result);
            }

            [TestMethod]
            public void TestSingleDigit()
            {
                var letterCombinations = new LetterCombinationsLeet();
                var result = letterCombinations.LetterCombinations("2");
                var expected = new List<string> { "a", "b", "c" };
                CollectionAssert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestTwoDigits()
            {
                var letterCombinations = new LetterCombinationsLeet();
                var result = letterCombinations.LetterCombinations("23");
                var expected = new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
                CollectionAssert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestThreeDigits()
            {
                var letterCombinations = new LetterCombinationsLeet();
                var result = letterCombinations.LetterCombinations("234");
                var expected = new List<string>
            {
                "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi",
                "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi",
                "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi"
            };
                CollectionAssert.AreEqual(expected, result);
            }

          
        }
    }

}