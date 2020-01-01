using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /* Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

    For example:
    Given binary tree[3, 9, 20, null, null, 15, 7],
                 3
                / \
               9  20
                 /  \
                15   7
    return its bottom-up level order traversal as:
            [
                [15,7], 
                [9,20],
                [3]
            ]*/


    [TestClass]
    public class BinaryTreeLevelOrderTraversalII
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var thisLevel = new List<int>();
                var queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    thisLevel.Add(currentNode.val);
                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
                result.Add(thisLevel);
            }

            result.Reverse();
            return result;
        }
        
        //recursion missing

        [TestMethod]
        public void TestMethod2()
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
