using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTreeGeneral
{
    public class SymmTree
    {
        public bool IsSymmetric(TreeNode root) {
            if (root == null) return false;
            return check(root.left,root.right);
        }
        bool check(TreeNode left, TreeNode right)
        {
            if (left == null && right==null)  return true;
            if (left == null || right == null) return false;
            return left.val == right.val && check(left.left, right.right) && check(left.right, right.left);

        }

        public bool IsSymmetric2(TreeNode root)
        {
            if (root == null) return false;
      
            bool isSymmetrical = true;

            var stack = new Stack<(TreeNode,TreeNode)>();
            stack.Push((root.left,root.right));
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node.Item1 == null ^ node.Item2 == null) { isSymmetrical = false; break; }
                if (node.Item1 != null && node.Item2 != null)
                {
                    if (node.Item1!.val != node.Item2!.val) { isSymmetrical = false; break; }
                    stack.Push((node.Item1.left, node.Item2.right));
                    stack.Push((node.Item1.right, node.Item2.left));
                }
            }

            return isSymmetrical;
        }
       
    }
}
