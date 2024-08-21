using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/count-complete-tree-nodes/
    public class CountCompleteTreeNodes
    {
        int depth = 0;
        bool toContinue = true;
        public int CountNodes(TreeNode root)
        {
            if (root==null) return 0;
            depth = MaxDepth(root);
            int completeTree = (int)Math.Pow(2,depth)-1;
            int missingNodes = FindMissingNode(root);
            return completeTree- missingNodes;
        }

        private int FindMissingNode(TreeNode node,int level=1)
        {   if (!toContinue) return 0;
            if (level==depth) return 0;
            if (level==depth-1) {
                int result = 0;
                if (node.right == null) result++;
                if (node.left == null) result++;
                else toContinue = false;
                return result;
            }
            return FindMissingNode(node.right,level+1)+ FindMissingNode(node.left, level + 1);
        }
        private int MaxDepth(TreeNode node)
        {
            int depth = 1;
            while (node.left != null)
            {
                depth++;
                node = node.left;
            }
            return depth;
        }
    }
}
