using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinimumDiff
    {
        private TreeNode? prevNode = null;
        int minDiff = int.MaxValue;
        public int GetMinimumDifference(TreeNode root)
        {
            InOrderTraversal(root);
            return minDiff;
        }
        private void InOrderTraversal(TreeNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.left);
            if (prevNode != null)
            {
                minDiff = Math.Min(node.val - prevNode.val, minDiff);
            }
            prevNode = node;
            InOrderTraversal(node.right);
        }
    }
}
