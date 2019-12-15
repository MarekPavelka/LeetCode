using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a sorted linked list, delete all duplicates such that each element appear only once.

    Example 1:

    Input: 1->1->2
    Output: 1->2
    Example 2:

    Input: 1->1->2->3->3
    Output: 1->2->3*/

    [TestClass]
    public class RemoveDuplicatesFromSortedList
    {
        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode head)
            {

            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int x) { val = x; }
    }
}
