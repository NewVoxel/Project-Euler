using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// Helper class to contain commonly used math functions/algorithms
    /// </summary>
    class Helper
    {
        /// <summary>
        /// Finds all primes up to a given number starting from 2
        /// </summary>
        /// <param name="num">Find all primes up to this number</param>
        /// <returns>Boolean array represeting prime numbers as true and composite numbers as false</returns>
        public bool[] FindPrimes(int num)
        {
            //Create array set all numbers to prime initially
            bool[] primes = new bool[num];
            for (int i = 0; i < num; i++)
            {
                primes[i] = true;
            }
            //Use Sieve of Eratosthenes algorithm to mark off numbers in array as composite
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    for (int j = i * 2; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
            return primes;
        }
    }
}
