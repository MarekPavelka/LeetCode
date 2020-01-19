using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given an integer array nums, find the sum of the elements between indices i and j(i ≤ j), inclusive.

    Example:
    Given nums = [-2, 0, 3, -5, 2, -1]

    sumRange(0, 2) -> 1
    sumRange(2, 5) -> -1
    sumRange(0, 5) -> -3
    Note:
    You may assume that the array does not change.
    There are many calls to sumRange function.*/


    [TestClass]
    public class RangeSumQuery
    {
        public class NumArray
        {
            int[] sums;

            public NumArray(int[] nums)
            {
                sums = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == 0)
                    {
                        sums[i] = nums[i];
                    }
                    else
                    {
                        sums[i] = sums[i - 1] + nums[i];
                    }
                }
            }

            public int sumRange(int i, int j)
            {
                if (i == 0)
                {
                    return sums[j];
                }
                return sums[j] - sums[i - 1];
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
