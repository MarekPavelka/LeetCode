using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".

//Example 1:

//Input: ["flower","flow","flight"]
//Output: "fl"
//Example 2:

//Input: ["dog","racecar","car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.
//Note:

//All given inputs are in lowercase letters a-z.


namespace LongestCommonPrefix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter words abstracted with \",\": ");
            var stringArrayFromUserInput =
                Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var trimmedInput = ReplaceWhiteSpaces(stringArrayFromUserInput);

            var lengthOfUserInputs = trimmedInput.Select(l => l.Length).ToList();

            var shortestInputInInputs = lengthOfUserInputs.Min();
            var indexOfShortestInput = lengthOfUserInputs.FindIndex(l => l == shortestInputInInputs); //predicate<int>

            var isEqualCounter = 0;
            for (int sequenceCut = shortestInputInInputs; sequenceCut >= 1; sequenceCut--)
            {
                var cuttedString = new String(trimmedInput[indexOfShortestInput].Take(sequenceCut).ToArray());

                for (int item = 0; item < trimmedInput.Count; item++)
                {
                    var actualString = new String(trimmedInput[item].Take(sequenceCut).ToArray());

                    if (actualString.SequenceEqual(cuttedString)) //contains
                    {
                        isEqualCounter++;
                    }
                }

                if (isEqualCounter != trimmedInput.Count)
                {
                    isEqualCounter = 0;
                }
                else if (isEqualCounter == trimmedInput.Count)
                {
                    Console.WriteLine($"Longest common prefix is {cuttedString}");
                    break;
                }
            }

            if (isEqualCounter != trimmedInput.Count)
            {
                Console.WriteLine($"There is no common prefix among the input strings");
            }

            Console.ReadLine();
        }

        public static List<string> ReplaceWhiteSpaces(List<string> list)
        {
            var trimmedList = new List<string>();
            foreach (var item in list)
            {
                trimmedList.Add(item.Replace(" ", String.Empty));
            }
            return trimmedList;
        }

    }
}