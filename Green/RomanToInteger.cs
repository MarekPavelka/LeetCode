﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green
{
    //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    //For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II.
    //The number twenty seven is written as XXVII, which is XX + V + II.
    //Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII.
    //Instead, the number four is written as IV.Because the one is before the five we subtract it making four.
    //The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
    //I can be placed before V (5) and X(10) to make 4 and 9. 
    //X can be placed before L(50) and C(100) to make 40 and 90. 
    //C can be placed before D(500) and M(1000) to make 400 and 900.
    //Given a roman numeral, convert it to an integer.Input is guaranteed to be within the range from 1 to 3999.

    //Input: "LVIII"
    //Output: 58
    //Explanation: L = 50, V= 5, III = 3.

    //Input: "MCMXCIV"
    //Output: 1994
    //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

    public enum RomanNumbers
    {
        I,
        V,
        X,
        L,
        C,
        D,
        M

    };

    class RomanToInteger
    {
        public static void Solution()
        {
            Console.WriteLine("Eneter ur number using Roman numbers (I,V,X,L,C,D,M): ");
            var romanNumberGiven = Console.ReadLine();


            Dictionary<char, int> hashTable = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            var outputNumber = 0;

            for (int i = 0; i < romanNumberGiven.Length - 1; i++)
            {
                //dorobit contains key
                int numberFromHashTable = hashTable[romanNumberGiven[i]];

                int nextNumberFromHashTable = hashTable[romanNumberGiven[i + 1]];

                if (numberFromHashTable >= nextNumberFromHashTable)
                {
                    outputNumber = outputNumber + numberFromHashTable;
                }
                else
                {
                    outputNumber = outputNumber - numberFromHashTable;
                }
            }

            outputNumber += hashTable[romanNumberGiven.Last()];

            Console.WriteLine($"Integer number from {romanNumberGiven} is {outputNumber}");
            Console.ReadLine();
        }
    }
}
