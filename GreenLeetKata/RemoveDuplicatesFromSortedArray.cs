using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /* 26. Remove Duplicates from Sorted Array
 
    Given a sorted array, remove the duplicates
    in place such that each element appear only once and return the new length.
    Do not allocate extra space for another array, you must do this in place with constant memory.
 
    For example,
    Given input array A = [1,1,2],
    Your function should return length = 2, and A is now [1,2]. */

    [TestClass]
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            var first = 0;
            for (int second = 1; second < nums.Length; second++)
            {
                if (nums[first] == nums[second])
                {
                    nums[second] = nums.FirstOrDefault(l => l > nums[second]);
                    if (nums[second] == 0 && nums[first] >= 0) return second;
                }
                else if (nums[first] > nums[second])
                {
                    nums[second] = nums.FirstOrDefault(l => l > nums[first]);
                    if (nums[second] == 0) return second;
                }
                first++;
            }
            return nums.Length;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            var input05 = new int[] {-3, -1, -1, 0, 0, 0, 0, 0, 2};
            var input0 = new int[] {-1, 0, 0, 0, 0, 3, 3};
            var input1 = new int[] {1, 1, 2};
            var input2 = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            var input3 = new int[] {1, 2, 3, 4};
            var input4 = new int[] {0, 0, 1, 3, 3, 8};

            var result05 = RemoveDuplicates(input05);
            var result0 = RemoveDuplicates(input0);
            var result1 = RemoveDuplicates(input1);
            var result2 = RemoveDuplicates(input2);
            var result3 = RemoveDuplicates(input3);
            var result4 = RemoveDuplicates(input4);

            result05.Should().Be(4);
            result0.Should().Be(3);
            result1.Should().Be(2);
            result2.Should().Be(5);
            result3.Should().Be(4);
            result4.Should().Be(4);
        }
    }
}
