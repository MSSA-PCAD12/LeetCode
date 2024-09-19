using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTreeGeneral
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    public class Leet_117
    {
        public Node Connect(Node root)
        {
            Queue<Node> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int itemCount = queue.Count;
                for (int i = 0; i < itemCount; i++)
                {
                    var node = queue.Dequeue();
                    if (i < itemCount - 1) {
                        node.next = queue.Peek();
                    }
                    if (node.left != null) { queue.Enqueue(node.left); }
                    if (node.right != null) { queue.Enqueue(node.right); }
                }

            }
            return root;
        }
    }
}
