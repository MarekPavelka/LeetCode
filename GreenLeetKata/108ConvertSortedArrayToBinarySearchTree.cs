using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

    For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

    Example:

    Given the sorted array: [-10,-3,0,5,9],

    One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

            0
           / \
         -3   9
         /   /
       -10  5*/

    [TestClass]
    public class ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode sortedArrayToBST(int[] nums)
        {
            return CreateBST(nums, 0, nums.Length - 1);
        }

        public TreeNode CreateBST(int[] nums, int startIdx, int endIdx)
        {
            if (startIdx > endIdx)
            {
                return null;
            }
            int midIdx = startIdx + (endIdx - startIdx) / 2;
            TreeNode root = new TreeNode(nums[midIdx]);
            root.left = CreateBST(nums, startIdx, midIdx - 1);
            root.right = CreateBST(nums, midIdx + 1, endIdx);
            return root;
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
