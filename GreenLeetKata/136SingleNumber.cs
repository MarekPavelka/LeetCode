using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a non-empty array of integers, every element appears twice except for one.Find that single one.

    Note:

    Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

    Example 1:

    Input: [2,2,1]
    Output: 1
    Example 2:

    Input: [4,1,2,1,2]
    Output: 4*/

    [TestClass]
    public class SingleNumber
    {
        public int SingleNum(int[] nums)
        {
            var result = 0;
            foreach (var number in nums)
            {
                result = result ^ number;
            }
            return result;
        }



        [TestMethod]
        public void WorksCorrectly()
        {
            var input = new int[] { 4, 1, 2, 1, 2 };
            var result = SingleNum(input);

            result.Should().Be(4);
        }
    }
}
