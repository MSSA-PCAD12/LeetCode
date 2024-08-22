using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BuildBST
    {
        public TreeNode? SortedArrayToBST(int[] nums)
        {
            if (nums.Length <= 0)
                return null;

            int mid = nums.Length / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = SortedArrayToBST(nums[..mid]);
            node.right = SortedArrayToBST(nums[(mid + 1)..]);
            return node;
        }
    }
}
