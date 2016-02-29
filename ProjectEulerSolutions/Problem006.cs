using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    class Problem006
    {
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Calculate sum of squares
            double sumOfSquares = 0;
            for(int i = 1; i <= 100; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
            }

            //Calculate square of sums
            double squareOfSums = 0;
            for(int i = 1; i <= 100; i++)
            {
                squareOfSums += i;
            }
            squareOfSums = Math.Pow(squareOfSums, 2);

            //Calculate difference between values and display answer
            double difference = Math.Abs(sumOfSquares - squareOfSums);
            Console.Out.WriteLine("The difference between the squareOfSums and sumOfSquares of numbers 1 - 100 is: " + difference);

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
