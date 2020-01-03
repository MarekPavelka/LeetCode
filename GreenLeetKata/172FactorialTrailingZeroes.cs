using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given an integer n, return the number of trailing zeroes in n!.

    Example 1:

    Input: 3
    Output: 0
    Explanation: 3! = 6, no trailing zero.
    Example 2:

    Input: 5
    Output: 1
    Explanation: 5! = 120, one trailing zero.
    Note: Your solution should be in logarithmic time complexity.*/

    [TestClass]
    public class FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            var result = 0;
            while (n > 4)
            {
                n = n / 5;
                result = result + n;
            }
            return result;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
