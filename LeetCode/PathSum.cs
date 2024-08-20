﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/path-sum/
    public class PathSum
    {
       

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return Process(root, 0,targetSum);
        }
        private bool Process(TreeNode node, int pathSum,int _targetSum)
        {
            if (node == null) return false;
            if (node.left == null && node.right == null)//is leaf node
            {
                return (pathSum + node.val == _targetSum);
                 
            }
            else
            {
                return Process(node.left, pathSum + node.val, _targetSum) || Process(node.right, pathSum + node.val, _targetSum);
            }
        }
    }
}
