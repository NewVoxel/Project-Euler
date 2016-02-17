using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Problem003
    {
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Variables to hold the number we're checking against and a list to hold all the factors we find
            long inputNumber = 600851475143;
            long initialNumber = inputNumber;
            List<long> factors = new List<long>();
            long dividingNumber = 2;

            //Keep dividing the initial number by the smallest whole number we can find repeatedly 
            while(inputNumber > 1)
            {
                while(inputNumber % dividingNumber == 0)
                {
                    factors.Add(dividingNumber);
                    inputNumber /= dividingNumber;
                }
                dividingNumber++;
                // A number never has prime factors higher than its square root so check where we're at
                // in relation to the input number and quit if the conditions are met
                if(dividingNumber*dividingNumber > inputNumber)
                {
                    if (inputNumber > 2)
                    {
                        factors.Add(inputNumber);
                        break;
                    }
                }
            }
            Console.Out.WriteLine("The largest prime factor of " + initialNumber + " is : " + factors[factors.Count - 1]);

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}