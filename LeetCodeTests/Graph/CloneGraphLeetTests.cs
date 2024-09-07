using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.Tests
{
    [TestClass]
    public class CloneGraphLeetTests
    {
        [TestMethod]
        public void TestCloneGraph_SingleNode()
        {
            // Arrange
            var node = new Node(1);
            var cloneGraphLeet = new CloneGraphLeet();

            // Act
            var clonedNode = cloneGraphLeet.CloneGraph(node);

            // Assert
            Assert.AreEqual(node.val, clonedNode.val);
            Assert.AreEqual(0, clonedNode.neighbors.Count);
        }

        [TestMethod]
        public void TestCloneGraph_TwoConnectedNodes()
        {
            // Arrange
            var node1 = new Node(1);
            var node2 = new Node(2);
            node1.neighbors.Add(node2);
            node2.neighbors.Add(node1);
            var cloneGraphLeet = new CloneGraphLeet();

            // Act
            var clonedNode1 = cloneGraphLeet.CloneGraph(node1);

            // Assert
            Assert.AreEqual(node1.val, clonedNode1.val);
            Assert.AreEqual(1, clonedNode1.neighbors.Count);
            Assert.AreEqual(node2.val, clonedNode1.neighbors[0].val);
            Assert.AreEqual(clonedNode1, clonedNode1.neighbors[0].neighbors[0]);
        }

        [TestMethod]
        public void TestCloneGraph_ComplexGraph()
        {
            // Arrange
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);
            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);
            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);
            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);
            var cloneGraphLeet = new CloneGraphLeet();

            // Act
            var clonedNode1 = cloneGraphLeet.CloneGraph(node1);

            // Assert
            Assert.AreEqual(node1.val, clonedNode1.val);
            Assert.AreEqual(2, clonedNode1.neighbors.Count);

        }

        [TestMethod]
        public void TestCloneGraph_NullNode()
        {
            // Arrange
            Node node = null;
            var cloneGraphLeet = new CloneGraphLeet();

            // Act
            var clonedNode = cloneGraphLeet.CloneGraph(node);

            // Assert
            Assert.IsNull(clonedNode);
        }
    }
}