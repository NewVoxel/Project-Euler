using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Set up variables
            bool isDivisible;
            //Loop through numbers in increments of 20 until conditions are met
            //Use 20 because it has to be divided by this amount so we may awell
            //save ourselves from iterating over 19 pointless steps
            for(int i = 20; true; i+=20)
            {
                isDivisible = true;
                //If current number is divisible by numbers 1-20 leave the loop
                for(int j = 20; j > 10; j--)
                {
                    if(i % j != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }
                //Present our results
                if (isDivisible)
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
