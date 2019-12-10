using System;
using System.Linq;

namespace Green
{
    /*Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.

    Example 1:

    Input: 121
    Output: true
    Example 2:

    Input: -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.*/

    public class Palindrome
    {
        public static void Solution()
        {
            Console.WriteLine("Enter word for Palindrome Check: ");
            var x = Console.ReadLine();
            Console.WriteLine(Palindrome.IsPalindrome(x));
        }

        public static bool IsPalindrome(string word)
        {
            var reversedCharArray = word.ToCharArray().Reverse().ToArray();
            var reversedWord = new string(reversedCharArray);

            if (word != reversedWord)
            {
                return false;
            }
            return true;
        }
    }
}

