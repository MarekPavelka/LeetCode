using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Given a pattern and a string str, find if str follows the same pattern.

    Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.

    Example 1:

    Input: pattern = "abba", str = "dog cat cat dog"
    Output: true
    Example 2:

    Input:pattern = "abba", str = "dog cat cat fish"
    Output: false
    Example 3:

    Input: pattern = "aaaa", str = "dog cat cat dog"
    Output: false
    Example 4:

    Input: pattern = "abba", str = "dog dog dog dog"
    Output: false
    Notes:
    You may assume pattern contains only lowercase letters, and str contains lowercase letters that may be separated by a single space.*/

    [TestClass]
    public class WordPattern
    {
        public bool WordPatterns(string pattern, string str)
        {
            var words = str.Split(' ');
            var patterns = pattern.ToCharArray();
            var map = new Dictionary<char, string>();
            if (patterns.Length != words.Length)
            {
                return false;
            }
            for (int i = 0; i < patterns.Length; i++)
            {
                if (map.ContainsKey(patterns[i]))
                {
                        
                    {
                        return false;
                    }
                }
                else
                {
                    if (map.ContainsValue(words[i]))
                    {
                        return false;    //case: "abba", "dog dog dog dog"
                    }
                    map.Add(patterns[i], words[i]);
                }
            }
            return true;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
