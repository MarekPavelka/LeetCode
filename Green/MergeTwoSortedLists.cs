using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Green
{
    /*
    Merge two sorted linked lists and return it as a new list.The new list should be made by splicing together the nodes of the first two lists.

    Example:
    Input: 1->2->4, 1->3->4
    Output: 1->1->2->3->4->4
    */

    class MergeTwoSortedLists
    {
        public static void Solution()
        {
            var List1 = new List<int>(){1,2,4};
            var List2 = new List<int>(){1,3,4};
            LinkedList<string> LinkedSortedList1 = new LinkedList<string>();
            LinkedSortedList1.AddLast("ferko");
            LinkedSortedList1.AddFirst("jozko");

            foreach (string str in LinkedSortedList1)
            {
                Console.WriteLine(str);
            }

            //LinkedListNode<> head = {value = 3, next = 3};
        }
    }
}
