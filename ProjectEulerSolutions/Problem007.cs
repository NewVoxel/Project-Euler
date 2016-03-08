using System;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    class Problem007
    {
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Using the sieve of Eratosthenes algorithm so just going to guess the 10,001st prime number is
            //below 200,000. Create bool array to represent numbers and set them all as being prime by default
            bool[] primeNumbers = new bool[200000];
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                primeNumbers[i] = true;
            }

            //Using 2 as the first prime number start marking off all multiples of 2 as not prime
            //Move to next number when at end of list and repeat for current number if marked as prime
            //eg next number is 3 which is prime so mark off all multiples of 3 as not prime
            //Keep doing this until we find the 10001st prime number
            int counter = 0;
            for(int i = 2; i < primeNumbers.Length; i++)
            {
                if(primeNumbers[i] == true)
                {
                    counter++;
                    if (counter == 10001)
                    {
                        Console.Out.WriteLine("The 10,001st prime number is: " + i);
                        break;
                    }
                    else
                    {
                        for (int j = i * 2; j < primeNumbers.Length; j += i)
                        {
                            primeNumbers[j] = false;
                        }
                    }
                }
            }

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
