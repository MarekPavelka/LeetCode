using System;
using FluentAssertions.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Write a program to check whether a given number is an ugly number.

    Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.

    Example 1:

    Input: 6
    Output: true
    Explanation: 6 = 2 × 3
    Example 2:

    Input: 8
    Output: true
    Explanation: 8 = 2 × 2 × 2
    Example 3:

    Input: 14
    Output: false 
    Explanation: 14 is not ugly since it includes another prime factor 7.
    Note:

    1 is typically treated as an ugly number.
    Input is within the 32-bit signed integer range: [−231,  231 − 1].*/

    [TestClass]
    public class UglyNumber
    {
        public bool IsUgly(int num)
        {
            if (num == 0)
            {
                return false;
            }
            var uglies = new int[] { 5, 3, 2 };
            foreach (int ugly in uglies)
            {
                while (num % ugly == 0)
                {
                    num = num / ugly;
                }
            }
            return num == 1;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            var input1 = 8;
            var input2 = 14;

            var result1 = IsUgly(input1);
            var result2 = IsUgly(input2);

            result1.IsSameOrEqualTo(true);
            result2.IsSameOrEqualTo(false);
        }
    }
}
