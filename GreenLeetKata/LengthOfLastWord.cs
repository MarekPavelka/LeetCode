using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

    If the last word does not exist, return 0.

    Note: A word is defined as a character sequence consists of non-space characters only.

    Example:

    Input: "Hello World"
    Output: 5*/

    [TestClass]
    public class LengthOfLastWord
    {
        public int LengthOfLstWord(string s)
        {
            var currentWordLength = 0;

            for (int i = s.Length-1; i >= 0 ; i--)
            {
                if (s[i] != ' ') currentWordLength++;
                else if (currentWordLength > 0) return currentWordLength;
            }

            return currentWordLength;
        }


        [TestMethod]
        public void WorksCorrectly()
        {
            var input1 = "Hello World";
            var input2 = "a";
            var input3 = "Today is a nice day";
            var input4 = "a ";


            var result1 = LengthOfLstWord(input1);
            var result2 = LengthOfLstWord(input2);
            var result3 = LengthOfLstWord(input3);
            var result4 = LengthOfLstWord(input4);

            result1.Should().Be(5);
            result2.Should().Be(1);
            result3.Should().Be(3);
            result4.Should().Be(1);
        }
    }
}
