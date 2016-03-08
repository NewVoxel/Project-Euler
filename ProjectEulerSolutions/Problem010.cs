using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// </summary>
    class Problem010
    {
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Get all prime numbers up to 2 million
            Helper MathHelper = new Helper();
            bool[] primes = MathHelper.FindPrimes(2000000);

            //Add up sum of all prime numbers and display answer
            double sumOfPrimes = 0;
            for(int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                    sumOfPrimes += i;
            }
            Console.Out.WriteLine("The sum of all primes up to the number 2 million is : " + sumOfPrimes);

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
