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
            //ReverseNumber.Solution();
            //Palindrome.Solution();
            TwoSum.Solution();
            Console.ReadLine();

        }
    }

    class TwoSum
    {
        public static void Solution()
        {
            var inputArray = new[] {1, 4, 2, 3, 5, 7}; //{5, 2, 4, 3, 1, -1}
            int target = 6;
            var result = GetIndexesToHitTarget(inputArray, target);
            Console.WriteLine($"1st index {result[0]} and 2nd index {result[1]}");
        }

        public static int[] GetIndexesToHitTarget(int[] inputArray, int target)
        {
            var controlArray = inputArray.Select(n => target - n).ToArray();
            var indexArray = new List<int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int i2 = i + 1; i2 < controlArray.Length; i2++)
                {
                    if (inputArray[i] + controlArray[i2] == target)
                    {
                        indexArray.Add(i);
                        indexArray.Add(i2);
                        return indexArray.ToArray();
                    }
                }
            }
            throw new ArgumentException("No 2 numbers from input[] sum up to target => bad input?");
        }
    }
}

