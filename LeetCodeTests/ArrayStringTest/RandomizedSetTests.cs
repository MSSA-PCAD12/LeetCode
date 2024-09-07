using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString.Tests
{
    [TestClass()]
    public class RandomizedSetTests
    {
        [TestMethod()]
        public void RandomizedSetTests1()
        {
            string[] actions = ["RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom"];
            int[][] parameters = [[], [1], [2], [2], [], [1], [2], []];
            object[] expected = [null, true, false, true, 2, true, false, 2];
            RandomizedSet? _set=null;
            bool? actual=null;
            for (int i = 0; i < actions.Length; i++) {
                switch (actions[i]) {
                    case "RandomizedSet": _set = new RandomizedSet();break;
                    case "insert":
                        actual = _set!.Insert(parameters[i][0]); Assert.AreEqual(expected[i], actual); break;
                    case "remove":
                        actual = _set!.Remove(parameters[i][0]); Assert.AreEqual(expected[i], actual); break;
                    case "getRandom":
                        int randoItem = _set!.GetRandom(); Assert.IsFalse(_set.Insert(randoItem)); break;
                }
            }
     
        }
        [TestMethod()]
        public void RandomizedSetTests2()
        {
            string[] actions = ["RandomizedSet", "remove", "remove", "insert", "getRandom", "remove", "insert"];
            int[][] parameters = [[], [0], [0], [0], [], [0], [0]];
            object[] expected = [null, false, false, true, 0, true, true];
            RandomizedSet? _set = null;
            bool? actual = null;
            for (int i = 0; i < actions.Length; i++)
            {
                switch (actions[i])
                {
                    case "RandomizedSet": _set = new RandomizedSet(); break;
                    case "insert":
                        actual = _set!.Insert(parameters[i][0]); Assert.AreEqual(expected[i], actual); break;
                    case "remove":
                        actual = _set!.Remove(parameters[i][0]); Assert.AreEqual(expected[i], actual); break;
                    case "getRandom":
                        int randoItem = _set!.GetRandom(); Assert.IsFalse(_set.Insert(randoItem)); break;
                }
            }

        }
    }
}