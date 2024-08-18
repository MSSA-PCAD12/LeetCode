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
    public class LinkedListCycleTests
    {
        [TestMethod()]
        public void HasCycleTest()
        {
           
            var node1 = new ListNode(3);
            var node2 = new ListNode(2);
            node1.next = node2;
            node2.next = new ListNode(0);
            node2.next.next = new ListNode(-4);
            node2.next.next.next = node2;

            bool expected = true;
            bool actual = new LinkedListCycle().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HasCycleTest2()
        {

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            node1.next = node2;
            node2.next =node1;
           

            bool expected = true;
            bool actual = new LinkedListCycle().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HasCycleTest3()
        {
            var node1 = new ListNode(1);
            bool expected = false;
            bool actual = new LinkedListCycle().HasCycle(node1);
            Assert.AreEqual(expected, actual);
        }
    }
}