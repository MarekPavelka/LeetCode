﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given an array of size n, find the majority element.The majority element is the element that appears more than ⌊ n/2 ⌋ times.

    You may assume that the array is non-empty and the majority element always exist in the array.

    Example 1:

    Input: [3,2,3]
    Output: 3
    Example 2:

    Input: [2,2,1,1,1,2,2]
    Output: 2*/

   [TestClass]
    public class MajorityElement
    {
        public int MajorityElem(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
