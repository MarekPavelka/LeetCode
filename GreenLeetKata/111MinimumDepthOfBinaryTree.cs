using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a binary tree, find its minimum depth.

    The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

    Note: A leaf is a node with no children.

    Example:

    Given binary tree[3, 9, 20, null, null, 15, 7],

            3
           / \
          9  20
          /  \
         15   7
    return its minimum depth = 2.*/


    [TestClass]
    public class MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftNode = MinDepth(root.left);
            var rightNode = MinDepth(root.right);

            if (leftNode == 0)
            {
                return rightNode + 1;
            }

            if (rightNode == 0)
            {
                return leftNode + 1;
            }

            return Math.Min(leftNode, rightNode) + 1;
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
