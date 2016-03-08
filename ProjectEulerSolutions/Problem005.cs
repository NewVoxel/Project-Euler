using System;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class Problem005
    {

        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Loop through numbers in increments of 20 until conditions are met
            //Use 20 because it has to be divided by this amount so we may awell
            //save ourselves from iterating over 19 pointless steps
            for(int i = 20; true; i+=20)
            {
                //If current number is divisible by numbers 1-20 leave the loop
                //No need to check numbers 1-10 since if they are divisible by
                //Numbers 11-20 we already know they are
                if ((i % 11) == 0 && (i % 12) == 0 && (i % 13) == 0 && (i % 14) == 0 
                    && (i % 15) == 0 && (i % 16) == 0 && (i % 17) == 0 && (i % 18) == 0 
                    && (i % 19) == 0 && (i % 20) == 0)
                {
                    Console.Out.WriteLine("The smallest number that is evenly divisible by numbers 1-20 is : " + i);
                    break;
                }
            }
            

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
