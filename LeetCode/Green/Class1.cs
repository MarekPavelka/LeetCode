using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var result = list.MySelect(ConvertToStringRepresentation).ToList();

            var result2 = list.Select(x => ConvertToStringRepresentation(x)).ToList();

            var result3 = list.Where(x => IsEven(x)).ToList();
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static string ConvertToStringRepresentation(int x)
        {
            //

            //
            //
            //
            //
            return "abc" + x;
        }
    }

    public class Palindrome
    {
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

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter word for Palindrome Check: ");
            var x = Console.ReadLine();
            Console.WriteLine(Palindrome.IsPalindrome(x));
            Console.ReadLine();
        }
    }
}

