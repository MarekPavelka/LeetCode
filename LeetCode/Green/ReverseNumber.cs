using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Green
{
    class ReverseNumber
    {
        public static void Solution()
        {
            Console.Write("Zadaj cislo ktore chces reversnut: ");
            var number = int.Parse(Console.ReadLine());
            var reversedString = ReverseNumber.ConvertToStringRepresentation(number);
            Console.WriteLine($"Reversed number is: {reversedString}");
            Console.ReadLine();
        }

        static string ConvertToStringRepresentation(int x)
        {
            var intToCharArray = x.ToString().ToCharArray().Reverse().ToArray();
            var reversedString = "";
            if (intToCharArray[0] == '0')
            {
                intToCharArray = intToCharArray.Skip(1).ToArray();
                reversedString = new string(intToCharArray);
            }

            if (intToCharArray.Last() == '-')
            {
                intToCharArray.Where(ch => ch != '-').ToList().Insert(0,'-');
                intToCharArray.ToArray();
                reversedString = new string(intToCharArray);
            }
            return reversedString;
        }
    }
}

