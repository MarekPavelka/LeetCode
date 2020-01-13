using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

    Example 1:

    Input: [3,0,1]
    Output: 2
    Example 2:

    Input: [9,6,4,2,3,5,7,0,1]
    Output: 8
    Note:
    Your algorithm should run in linear runtime complexity.Could you implement it using only constant extra space complexity?*/

   [TestClass]
    public class MissingNumber
    {
        public int MissingNum(int[] nums)
        {
            int xor = 0;
            int i = 0;
            for (; i < nums.Length; i++)
            {
                xor = xor ^ i ^ nums[i];
            }
            return xor ^ i;
        }


        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
