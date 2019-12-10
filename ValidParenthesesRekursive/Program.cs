using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParenthesesRekursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parenthases: ");
            var userInput = Console.ReadLine();
            var ferko = new Program();
            Console.WriteLine($"Valid parentheses = {ferko.IsValid(userInput)}");
            Console.ReadLine();
        }

        public bool IsValid(string s) //              "[ ( { ( ( ) ) } [ ( ) ] ) ]"                                     
        {
            if (s == String.Empty)
            {
                return true;
            }

            if (s.Length % 2 != 0)
            {
                return false;
            }

            var correctPairs = "()[]{}";
            
            var currentItem = s[s.Length - 1];
            var indexOfItemInCorrectPairs = correctPairs.IndexOf(currentItem);
            char itemToFind;

            if (indexOfItemInCorrectPairs % 2 != 0)
            {
                itemToFind = correctPairs[indexOfItemInCorrectPairs - 1];
            }
            else
            {
                itemToFind = correctPairs[indexOfItemInCorrectPairs + 1];
            }

            if (s.Contains(itemToFind))
            {
                var indexOfFirst = s.IndexOfAny(new[] { itemToFind });

                if (indexOfFirst + 1 == s.Length - 1)
                {

                }
                if (((s.Length-1) - (indexOfFirst+1)) % 2 == 0)
                {
                    var stringWithoutLast = new string(s.Take(s.Length - 1).ToArray());

                    return IsValid(stringWithoutLast.Remove(indexOfFirst, 1));
                }
                return false;
            }
            return false;
        }
    }
}
