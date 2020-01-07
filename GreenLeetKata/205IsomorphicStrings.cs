using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given two strings s and t, determine if they are isomorphic.

    Two strings are isomorphic if the characters in s can be replaced to get t.

    All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character but a character may map to itself.

    Example 1:

    Input: s = "egg", t = "add"
    Output: true
    Example 2:


    Input: s = "foo", t = "bar"
    Output: false
    Example 3:


    Input: s = "paper", t = "title"
    Output: true*/


   [TestClass]
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if(s == null || s.Length == 0) 
            {
                return (t == null || t.Length == 0);
            }
            if (t == null || t.Length == 0)
            {
                return (s == null || s.Length == 0);
            }
            var dict = new Dictionary<char, char>();
            if (s.Length != t.Length)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsKey(t[i]))
                    {
                        return false; // ab aa
                    }
                    dict[s[i]] = t[i];
                }
            }
            return true;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            //not functional
        }
    }
}
