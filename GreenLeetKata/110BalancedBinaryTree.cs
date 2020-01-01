using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a binary tree, determine if it is height-balanced.

    For this problem, a height-balanced binary tree is defined as:

    a binary tree in which the left and right subtrees of every node differ in height by no more than 1.




    Example 1:

    Given the following tree [3,9,20,null,null,15,7]:

            3
           / \
          9  20
          /  \
         15   7
        Return true.

    Example 2:

    Given the following tree [1,2,2,3,3,null,null,4,4]:

            1
           / \
          2   2
             / \
            3   3
               / \
              4   4
        Return false.*/


    [TestClass]
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            else if (Math.Abs(GetHeight(root.left) - GetHeight(root.right)) > 1)
            {
                return false;
            }
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int leftHeight = GetHeight(node.left);
            int rightHeight = GetHeight(node.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public bool isBalanced2(TreeNode root)
        {
            return GetHeight(root) != -1;
        }

        private int GetH2(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftH = GetH2(root.left);
            if (leftH == -1)
            {
                return -1;
            }
            int rightH = GetH2(root.right);
            if (rightH == -1)
            {
                return -1;
            }
            if (Math.Abs(leftH - rightH) > 1)
            {
                return -1;
            }
            return Math.Max(leftH, rightH) + 1;
        }

        [TestMethod]
        public void TestMethod1()
        {
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
