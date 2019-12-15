using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /*Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

    The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

    You may assume the integer does not contain any leading zero, except the number 0 itself.

    Example 1:

    Input: [1,2,3]
    Output: [1,2,4]
    Explanation: The array represents the integer 123.*/

    [TestClass]
    public class PlusOne
    {
        public int[] PlusOneDigit(int[] digits)
        {
            for (int idx = digits.Length - 1; idx >= 0; idx--)
            {
                if (digits[idx] == 9) digits[idx] = 0;
                else
                {
                    digits[idx] += 1;
                    break;
                }
            }

            if (digits[0] == 0)
            {
                var helperList = digits.ToList();
                helperList.Insert(0, 1);
                return helperList.ToArray();
            }

            return digits;
        }



        [TestMethod]
        public void WorksCorrectly()
        {
            var input1 = new int[] { 1, 2, 3 };
            var input2 = new int[] { 9, 9, 9 };
            var input3 = new int[] { 4, 9, 9 };
            var input4 = new int[] { 2, 4, 9, 3, 9 };

            var result1 = PlusOneDigit(input1);
            var result2 = PlusOneDigit(input2);
            var result3 = PlusOneDigit(input3);
            var result4 = PlusOneDigit(input4);

            result1.Should().BeEquivalentTo(new int[] { 1, 2, 4 });
            result2.Should().BeEquivalentTo(new int[] { 1, 0, 0, 0 });
            result3.Should().BeEquivalentTo(new int[] { 5, 0, 0 });
            result4.Should().BeEquivalentTo(new int[] { 2, 4, 9, 4, 0 });
        }
    }
}
