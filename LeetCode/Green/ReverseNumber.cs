using System;
using System.Collections.Generic;
using System.Linq;

namespace Green
{
    class ReverseNumber
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo ktore chces reversnut:");
            var number = int.Parse(Console.ReadLine());
            var reversedString = ReverseNumber.ConvertToStringRepresentation(number);
            Console.ReadLine();
        }
        //var list = new List<int> { 1, 2, 3, 4, 5 };
        //var result = list.Select(ConvertToStringRepresentation).ToList();

        //var result2 = list.Select(x => ConvertToStringRepresentation(x)).ToList();

        //var result3 = list.Where(x => IsEven(x)).ToList();
        //}

        //static bool IsEven(int x)
        //{
        //return x % 2 == 0;
        //}

        static string ConvertToStringRepresentation(int x)
        {
            var intToCharArray = x.ToString().ToCharArray().Reverse().ToArray();
            if (intToCharArray[0] == '0')
            {
                intToCharArray.Skip(1);
            }

            if (intToCharArray[intToCharArray.Length - 1] == '-')
            {
                intToCharArray.
            }



            var reversedString = new string(intToCharArray);
            return reversedString;
        }
    }
}

