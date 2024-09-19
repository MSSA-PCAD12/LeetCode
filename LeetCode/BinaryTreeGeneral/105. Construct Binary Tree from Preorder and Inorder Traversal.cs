using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTreeGeneral
{

    public class BuildTreeFromPreOrderAndInOrder
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0) return null;
           
            TreeNode parent = new TreeNode(preorder[0]);
            int inorderIndexOfParent = Array.IndexOf(inorder, preorder[0]);
            parent.left = BuildTree(preorder[1..(inorderIndexOfParent+1)], inorder[0..inorderIndexOfParent] );
            parent.right = BuildTree(preorder[(inorderIndexOfParent+1)..], inorder[(inorderIndexOfParent+1)..] );
            return parent;
        }

    }
}
