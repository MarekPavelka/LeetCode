using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /*Given two strings s and t, write a function to determine if t is an anagram of s.

    Example 1:

    Input: s = "anagram", t = "nagaram"
    Output: true
    Example 2:


    Input: s = "rat", t = "car"
    Output: false
    Note:
    You may assume the string contains only lowercase alphabets.

    Follow up:
    What if the inputs contain unicode characters? How would you adapt your solution to such case?*/

   [TestClass]
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
                var chars1 = s.ToCharArray();
                var chars2 = s.ToCharArray();
                Array.Sort(chars1);
                Array.Sort(chars2);
                return new string(chars1).Equals(new string(chars2);
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
