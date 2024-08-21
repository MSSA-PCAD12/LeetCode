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
            int level = 0;
            bool isSymmetrical = false;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node == null) continue;
            }

            return false;
        }
       
    }
}
