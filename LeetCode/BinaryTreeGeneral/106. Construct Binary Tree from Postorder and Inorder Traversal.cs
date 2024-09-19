using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTreeGeneral
{

    public class BuildTreeFromPostOrderAndInOrder
    {
        public TreeNode BuildTree(int[] inorder,int[] postorder)
        {
            if (postorder.Length == 0 || inorder.Length == 0) return null;

            TreeNode parent = new TreeNode(postorder[^1]);
            int inorderIndexOfParent = Array.IndexOf(inorder, postorder[^1]);
            if (postorder.Length == 1) return parent;
            parent.left = BuildTree( inorder[0..inorderIndexOfParent], postorder[0..(inorderIndexOfParent)]);
            parent.right = BuildTree(inorder[(inorderIndexOfParent + 1)..], postorder[(inorderIndexOfParent)..^1]);
            return parent;
        }
    }
}
