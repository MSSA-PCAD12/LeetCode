using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
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
    }
}
