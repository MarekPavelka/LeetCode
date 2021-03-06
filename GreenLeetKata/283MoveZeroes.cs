﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

    Example:

    Input: [0,1,0,3,12]
    Output: [1,3,12,0,0]
    Note:

    You must do this in-place without making a copy of the array.
    Minimize the total number of operations.*/

    [TestClass]
    public class MoveZeroes
    {
        public void MoveZero(int[] nums)
        {
            for (int i = 0, j = 0; i < nums.Length && j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    int temp = nums[i];
                    nums[i++] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
