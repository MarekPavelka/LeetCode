using System;

//Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
//An input string is valid if:
//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Note that an empty string is also considered valid.

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)                         
        {
            Console.WriteLine("Enter parenthases: ");
            var userInput = Console.ReadLine();
            Console.WriteLine($"Valid parentheses = {IsValid(userInput)}");
            Console.ReadLine();
        }

        public static bool IsValid(string s)                            // (([]){}    [ ( { ( ( ) ) } [( )] ) ]"
        {
            if (s == String.Empty)
            {
                return true;
            }
            if (s.Length % 2 != 0)
            {
                return false;
            }
            var correctPairs = "(),[],{},";
            var leftSideIndex = s.Length / 2 - 1;
            var rightSideIndex = s.Length / 2;
            var actualPair = new string(new[] { s[leftSideIndex], s[rightSideIndex] });

            ulong ulongLength = Convert.ToUInt64(s.Length);
            if ((ulongLength & (ulongLength - 1)) == 0) 
            {
                if (correctPairs.Contains(actualPair))
                {
                    return IsValid(s.Remove(leftSideIndex, 2));                     
                }
                if (!correctPairs.Contains(actualPair) && s.Length > 2)
                {
                    var powerOf2Pair = new string(new[] { s[leftSideIndex - 1], s[rightSideIndex - 1] });
                    if (correctPairs.Contains(powerOf2Pair))
                    {
                        return IsValid(s.Remove(leftSideIndex - 1, 2));
                    }
                    return false;
                }

            }
            if (correctPairs.Contains(actualPair))
            {
                return IsValid(s.Remove(leftSideIndex, 2));
            }
            if (!correctPairs.Contains(actualPair) && s.Length > 2)
            {
                var powerOf2Pair = new string(new[] { s[leftSideIndex - 1], s[rightSideIndex - 1] });
                if (correctPairs.Contains(powerOf2Pair))
                {
                    return IsValid(s.Remove(leftSideIndex - 1, 2));
                }
                return false;
            }
            return false;
        }
    }
}



