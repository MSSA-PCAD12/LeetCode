using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTreeLevelAccess
{
    public class LevelOrderLeet
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            IList<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int levelCount = q.Count;
                List<int> level = new List<int>();
                for (int i = 0; i < levelCount; i++)
                {
                    var node = q.Dequeue();
                    level.Add(node.val);
                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }
                }
                result.Add(level);
            }
            return result;
        }
    }
}
