using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Green;
using FluentAssertions;
using System.Linq;

namespace UnitMSTest
{
    /*Write a function to find the longest common prefix string amongst an array of strings.
    If there is no common prefix, return an empty string "".

    Example 1:
    Input: ["flower","flow","flight"]
    Output: "fl"

    Example 2:
    Input: ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.

    Note:
    All given inputs are in lowercase letters a-z.*/

    [TestClass]
    public class LongestCommonPrefix
    {
        public string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string prefix = strs.OrderBy(l => l.Length).First();
            for (int i = 0; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == string.Empty)
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            var input = new string[] { "ferko", "fer", "f" };

            var result = longestCommonPrefix(input);
            result.Should().Be("f");
        }

        [TestMethod]
        public void ReturnsEmptyStringForEmptyInput()
        {
            var input = new string[] { };

            var result = longestCommonPrefix(input);
            result.Should().Be("");
        }

        [TestMethod]
        public void ReturnsEmptyStringWhenNoCommonPrefix()
        {
            var input = new string[] { "ferko", "joz", "zolo" };

            var result = longestCommonPrefix(input);
            result.Should().Be("");
        }
    }
}
