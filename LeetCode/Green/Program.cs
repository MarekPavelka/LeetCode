using System;
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
            //TwoSum.Solution();
            System.DateTime actualDateTime = System.DateTime.Now;
            Console.WriteLine($"{actualDateTime}");
            Console.WriteLine($"{actualDateTime.Day}");
            Console.WriteLine($"{actualDateTime.Hour}");
            Console.WriteLine($"{actualDateTime.Minute}");
            Console.WriteLine($"{actualDateTime.Millisecond}");
            Console.WriteLine($"{actualDateTime.Date}");
            

            Console.ReadLine();
        }
    }
}

