using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaxDepthBinaryTree
    {
        int maxLevel = 0;
        public async Task<int> MaxDepth(TreeNode root)
        {
            int level = 0;
            if (root != null)
               await Process(root, level);

            return maxLevel;
        }
        public async Task Process(TreeNode node, int level)
        {
            level += 1;
            maxLevel = Math.Max(maxLevel, level);
            if (node.right != null) { await Process(node.right, level); }
            if (node.left != null) { await Process(node.left, level); }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
