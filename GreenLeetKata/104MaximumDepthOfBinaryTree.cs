﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /* Given a binary tree, find its maximum depth.

    The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

    Note: A leaf is a node with no children.

    Example:

    Given binary tree[3, 9, 20, null, null, 15, 7],

             3
            / \
           9  20
             /  \
            15   7
    return its depth = 3.*/

    [TestClass]
    public class MaximumDepthOfBinaryTree
    {
        public class Solution
        {
            public int MaxDepth(TreeNode root)
            {
                if (root == null) return 0;

                return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
            }

            [TestMethod]
            public void TestMethod1()
            {
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }
    }
}
