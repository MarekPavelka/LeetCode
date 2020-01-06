using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /*Count the number of prime numbers less than a non-negative number, n.

    Example:

    Input: 10
    Output: 4
    Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.*/

    [TestClass]
    public class CountPrimes
    {
        public int CountPrime(int n)
        {
            var isPrime = new bool[n];
            int counter = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    counter++;
                    for (int j = 2; i * j < n; j++)
                    {
                        isPrime[i * j] = false;
                    }
                }
            }
            return counter;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
