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
        public ListNode DeleteDuplicates(ListNode head)
        {
            var currentNode = head;


            while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.val == currentNode.next.val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else currentNode = currentNode.next;
            }

            return head;
        }

        [TestMethod]
        public void WorksCorrectly()
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
