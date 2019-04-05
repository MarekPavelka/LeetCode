using System;
using System.Linq;

namespace Green
{
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

