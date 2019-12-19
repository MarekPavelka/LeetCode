using System;
using System.Linq;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

    Note: For the purpose of this problem, we define empty string as valid palindrome.

    Example 1:

    Input: "A man, a plan, a canal: Panama"
    Output: true

    Example 2:

    Input: "race a car"
    Output: false*/

    [TestClass]
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var startIndex = 0;
            var endIndex = s.Length - 1;

            while (startIndex < endIndex)
            {
                while (startIndex < endIndex && !Char.IsLetterOrDigit(s[startIndex]))
                    startIndex++;

                while (startIndex < endIndex && !Char.IsLetterOrDigit(s[endIndex]))
                    endIndex--;

                if (Char.ToLowerInvariant(s[startIndex]) != Char.ToLowerInvariant(s[endIndex]))
                    return false;

                startIndex++;
                endIndex--;
            }
            return true;
        }

        public bool IsPalindrome2(string s)
        {
            if (s == String.Empty) return true;

            var startingHalf = new StringBuilder();
            var alphaNumTrimString = new StringBuilder();

            foreach (var sign in s)
            {
                if (Char.IsLetterOrDigit(sign)) alphaNumTrimString.Append(Char.ToLowerInvariant(sign));
            }

            var halfLength = alphaNumTrimString.Length / 2;
            for (int i = 0; i < halfLength-1; i++)
            {
                startingHalf.Append(alphaNumTrimString[i]);
                startingHalf.ToString().Reverse();
            }

            alphaNumTrimString.Remove(0, halfLength);
            if (!startingHalf.ToString().Equals(alphaNumTrimString.ToString())) return false;

            return true;
        }


        [TestMethod]
        public void TestMethod1()
        {
            var input1 = "A man, a plan, a canal: Panama";
            var input2 = "race a car";

            var result1 = IsPalindrome2(input1);
            var result2 = IsPalindrome2(input2);

            result1.Should().Be(true);
            result2.Should().Be(false);
        }
    }
}
