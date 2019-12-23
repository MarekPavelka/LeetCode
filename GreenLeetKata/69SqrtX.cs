using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /*Implement int sqrt(int x).

    Compute and return the square root of x, where x is guaranteed to be a non-negative integer.

    Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.

    Example 1:

    Input: 4
    Output: 2
    Example 2:

    Input: 8
    Output: 2
    Explanation: The square root of 8 is 2.82842..., and since 
             the decimal part is truncated, 2 is returned.*/

    [TestClass]
    public class SqrtX
    {
        public int MySqrt(int x)
        {
            long leftNumber = 0;
            long rightNumber = x / 2 + 1;
            while (leftNumber <= rightNumber)
            {
                long mid = leftNumber + (rightNumber - leftNumber) / 2;
                long result = mid * mid;
                if (result == x) return Convert.ToInt32(mid);
                else if (result > x) rightNumber = mid - 1;
                else leftNumber = mid + 1;

            }
            return Convert.ToInt32(rightNumber);
        }


        [TestMethod]
        public void WorksCorrectly()
        {
            var input1 = 4;
            var input2 = 8;
            var input3 = 17;

            var result1 = MySqrt(input1);
            var result2 = MySqrt(input2);
            var result3 = MySqrt(input3);

            result1.Should().Be(2);
            result2.Should().Be(2);
            result3.Should().Be(4);
        }
    }
}
