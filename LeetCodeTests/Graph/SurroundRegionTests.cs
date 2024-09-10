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
    public class SurroundRegionTests
    {
        [TestMethod]
        public void TestAllSurroundedRegions()
        {
            char[][] board = {
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'O', 'O', 'X'},
                new char[] {'X', 'O', 'O', 'X'},
                new char[] {'X', 'X', 'X', 'X'}
            };

            char[][] expected = {
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'}
            };

            new SurroundRegion().Solve(board);
            CollectionAssert.AreEqual(expected[0], board[0]);
            CollectionAssert.AreEqual(expected[1], board[1]);
            CollectionAssert.AreEqual(expected[2], board[2]);
            CollectionAssert.AreEqual(expected[3], board[3]);
        }
        [TestMethod]
        public void TestAllSurroundedRegions2()
        {
            char[][] board = {
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'O', 'O', 'X'},
                new char[] {'X', 'X', 'O', 'X'},
                new char[] {'X', 'O', 'X', 'X'}
            };

            char[][] expected = {
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'O', 'X', 'X'}
            };

            new SurroundRegion().Solve(board);
            for (int i = 0; i < expected.Length; i++) {
                CollectionAssert.AreEqual(expected[i], board[i]);
            }
        }
    }
   

}