using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/invert-binary-tree/
    public class InvertTreeLeet
    {
        public TreeNode InvertTree(TreeNode root)
        {
                if (root == null) return root;

                (root!.left, root.right) = (root.right, root.left);
                InvertTree(root.left);
                InvertTree(root.right);
                return root;
  
        }
        public TreeNode InvertTree2(TreeNode root)
        {
            if (root == null) return root;
            Stack<TreeNode?> stack = new Stack<TreeNode?>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack!.Pop();
                (node.left,node.right)=(node.right,node.left);
                if (node.left != null) { stack.Push(node.left); }
                if (node.right != null) { stack.Push(node.right); }

            }
            return root;

        }
    }
}
