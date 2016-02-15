using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    /// The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem001
    {
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();
            //Create a list to hold all divisible numbers
            List<int> multiples = new List<int>();
            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }
            //Cycle through all of the numbers that are a multiple of 3 or 5 and add them together
            int totalSum = 0;
            foreach(int i in multiples)
            {
                totalSum += i;
            }
            //Display the total sum of all numbers to the user!
            Console.Out.WriteLine("The total sum of all of the multiples of 3 and 5 below 1000 is : " + totalSum);
            watch.Stop();
            //Display time taken to execute program
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}