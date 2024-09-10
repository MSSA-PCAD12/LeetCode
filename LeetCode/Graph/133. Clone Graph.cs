using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
    public class CloneGraphLeet
    {
        private Dictionary<Node, Node> map = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            if (map.ContainsKey(node))
            {
                return map[node];
            }

            // Create a clone for the given node
            Node clone = new Node(node.val);
            map[node] = clone;

            // Recursively clone all the neighbors
            foreach (Node neighbor in node.neighbors)
            {
                clone.neighbors.Add(CloneGraph(neighbor));
            }

            return clone;
        }
    }
}
