using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /*Given a binary tree, return all root-to-leaf paths.

    Note: A leaf is a node with no children.

    Example:

    Input:

    1
    /   \
    2     3
    \
    5

    Output: ["1->2->5", "1->3"]

    Explanation: All root-to-leaf paths are: 1->2->5, 1->3*/

    [TestClass]
    public class BinaryTreePaths
    {
        public class Solution
        {
            public IList<string> BinaryTreePaths(TreeNode root)
            {
                var paths = new List<string>();
                if (root == null)
                {
                    return paths;
                }

                dfs(root, paths, "");
                return paths;
            }

            private void dfs(TreeNode root, List<string> paths, string path)
            {
                if (root.left == null && root.right == null)
                {
                    paths.Add(path + root.val);
                    return;
                }

                path += root.val + "->";
                if (root.left != null)
                {
                    dfs(root.left, paths, path);
                }

                if (root.right != null)
                {
                    dfs(root.right, paths, path);
                }
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

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}