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
    public class MergeTwoListsLeetTests
    {
        [TestMethod()]
        public void MergeTwoListsTest1()
        {
            var node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(4);

            var node2 = new ListNode(1);
            node2.next = new ListNode(3);
            node2.next.next = new ListNode(4);

            int[] expected = [1, 1, 2, 3, 4, 4];
            
            ListNode headNode = new MergeTwoListsLeet().MergeTwoLists(node1,node2);
            List<int> results = new List<int>();
            results.Add(headNode.val);
            while (headNode.next != null) {
                results.Add(headNode.next.val);
                headNode = headNode.next;}
            CollectionAssert.AreEqual(expected, results.ToArray());
        }
    }
}