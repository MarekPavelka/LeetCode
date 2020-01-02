using System;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a positive integer, return its corresponding column title as appear in an Excel sheet.

    For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB
    ...
    Example 1:

    Input: 1
    Output: "A"
    Example 2:

    Input: 28
    Output: "AB"
    Example 3:

    Input: 701
    Output: "ZY"*/


    [TestClass]
    public class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            var stringBuilder = new StringBuilder();

            while (n != 0)
            {
                int temporaryChar = (n - 1) % 26;
                stringBuilder.Append((char)(temporaryChar + 65));
                n = (n - 1) / 26;
            }

            var sbIntoChars = stringBuilder.ToString().ToCharArray();
            Array.Reverse(sbIntoChars);

            return new string(sbIntoChars);
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
