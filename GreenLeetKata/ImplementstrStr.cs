using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Implement strStr().

    Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

    Example 1:
    
    Input: haystack = "hello", needle = "ll"
    Output: 2
    Example 2:

    Input: haystack = "aaaaa", needle = "bba"
    Output: -1
    Clarification:

    What should we return when needle is an empty string? This is a great question to ask during an interview.

    For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().*/

    [TestClass]
    public class ImplementstrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            if (!haystack.Contains(needle)) return -1;
            return haystack.IndexOf(needle);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
