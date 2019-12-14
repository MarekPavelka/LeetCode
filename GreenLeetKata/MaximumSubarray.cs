using System;
using System.CodeDom;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    
    /*Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum.

    Example:

    Input: [-2,1,-3,4,-1,2,1,-5,4],
    Output: 6
    Explanation: [4,-1,2,1] has the largest sum = 6.*/

    [TestClass]
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var currentMax = nums[0];
            var max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var currentNumber = nums[i];

                if (currentNumber >= currentNumber + currentMax) currentMax = currentNumber;
                else currentMax = currentMax + currentNumber;
                if (max < currentMax) max = currentMax;
            }

            return max;
        }



        [TestMethod]
        public void WorksCorrectly()
        {
            var input1 = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            var input2 = new int[] {2, 1, 4, -1, 1, 1, 6};
            var result1 = MaxSubArray(input1);
            var result2 = MaxSubArray(input2);

            result1.Should().Be(6);
            result2.Should().Be(14);
        }
    }
}
