using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given two binary trees, write a function to check if they are the same or not.

    Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

    Example 1:

    Input:       1         1
                / \       / \
               2   3     2   3

              [1,2,3], [1,2,3]

    Output: true

    Example 2:

    Input:     1         1
              /           \
             2             2

            [1,2], [1,null,2]

    Output: false

    Example 3:

    Input:     1         1
              / \       / \
             2   1     1   2

            [1,2,1], [1,1,2]

    Output: false*/

    [TestClass]
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null) return p == q;
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
