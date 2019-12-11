using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a 32-bit signed integer, reverse digits of an integer.

    Example 1:

    Input: 123
    Output: 321
    Example 2:

    Input: -123
    Output: -321
    Example 3:

    Input: 120
    Output: 21
    Note:
    Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
    For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.*/

    [TestClass]
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            long result = 0;

            while (x != 0)
            {
                result = result * 10 + x % 10;
                x = x / 10;
            }

            if (result > Int32.MaxValue || result < Int32.MinValue)
            {
                return 0;
            }
            return Convert.ToInt32(result);
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            var input = 321;
            var input2 = -123;
            var result = Reverse(input);
            var result2 = Reverse(input2);

            result.Should().Be(123);
            result2.Should().Be(-321);
        }

        [TestMethod]
        public void LastNumberZero()
        {
            var input = 120;
            var result = Reverse(input);

            result.Should().Be(21);
        }

        [TestMethod]
        public void IntegerOverflow()
        {
            int input = 2147483643;
            var result = Reverse(input);

            result.Should().Be(0);
        }
    }
}
