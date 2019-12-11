using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /*Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Note that an empty string is also considered valid.

    Example 1:

    Input: "()"
    Output: true
    Example 2:

    Input: "()[]{}"
    Output: true
    Example 3:

    Input: "(]"
    Output: false
    Example 4:

    Input: "([)]"
    Output: false
    Example 5:

    Input: "{[]}"
    Output: true*/

    [TestClass]
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var isOpeningBracket = s[i] == '(' || s[i] == '{' || s[i] == '[';

                if (isOpeningBracket) stack.Push(s[i]);
                else
                {
                    if (!stack.Any()) return false;
                    if (stack.Peek() == '(' && s[i] != ')') return false;
                    else if (stack.Peek() == '{' && s[i] != '}') return false;
                    else if (stack.Peek() == '[' && s[i] != ']') return false;
                    stack.Pop();
                }
            }
            return (stack.Count == 0);
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            var input1 = "()";
            var input2 = "()[]{}";
            var input3 = "(]";
            var input4 = "([)]";
            var input5 = "{[]}";

            var result1 = IsValid(input1);
            var result2 = IsValid(input2);
            var result3 = IsValid(input3);
            var result4 = IsValid(input4);
            var result5 = IsValid(input5);

            result1.Should().Be(true);
            result2.Should().Be(true);
            result3.Should().Be(false);
            result4.Should().Be(false);
            result5.Should().Be(true);
        }

        [TestMethod]
        public void WorkingForHardExample()
        {
            var input = "[({(())}[()])]";
            var result = IsValid(input);

            result.Should().Be(true);
        }
    }
}
