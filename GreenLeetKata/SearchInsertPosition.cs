using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a sorted array and a target value, return the index if the target is found.
     If not, return the index where it would be if it were inserted in order.

    You may assume no duplicates in the array.

    Example 1:
    
    Input: [1,3,5,6], 5
    Output: 2
    
    Example 2:
    
    Input: [1,3,5,6], 2
    Output: 1
    
    Example 3:

    Input: [1,3,5,6], 7
    Output: 4
    Example 4:

    Input: [1,3,5,6], 0
    Output: 0*/

    [TestClass]
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            var currentNumber = 0;
            for (int secondIndex = 0; secondIndex < nums.Length; secondIndex++)
            {
                if (nums[secondIndex] == target) return secondIndex;
                currentNumber = nums[secondIndex];
                if (currentNumber > target) return secondIndex;
            }

            return nums.Length;
        }



        [TestMethod]
        public void WorksCorrectly()
        {
            var input = new int[] {1, 3, 5, 6};

            var result3 = SearchInsert(input, 7);
            var result1 = SearchInsert(input, 5);
            var result2 = SearchInsert(input, 2);
            var result4 = SearchInsert(input, 0);

            result3.Should().Be(4);
            result1.Should().Be(2);
            result2.Should().Be(1);
            result4.Should().Be(0);
        }
    }
}
