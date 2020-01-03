using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a column title as appear in an Excel sheet, return its corresponding column number.

    For example:

    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 
    ...
    Example 1:

    Input: "A"
    Output: 1
    Example 2:

    Input: "AB"
    Output: 28
    Example 3:

    Input: "ZY"
    Output: 701*/

    [TestClass]
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            var result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += (s[i] - 64) * ((int)Math.Pow(26, s.Length - i - 1)); //ASCII A == 65
            }

            return result;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
