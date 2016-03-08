using System;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    class Problem009
    {
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a less than b less than c, for which,
        /// a^2 + b^2 = c^2
        /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Just brute force through the numbers until the solution to the problem is found
            bool found = false;
            for(double a = 1; a < 1000; a++)
            {
                if (found)
                    break;
                for(double b = a; b < 1000; b++)
                {
                    if (found)
                        break;
                    for(double c = b; c < 1000; c++)
                    {
                        if (found)
                            break;
                        if(a + b + c == 1000)
                        {
                            if(Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)) {
                                double product = a * b * c;
                                Console.Out.WriteLine(a + " * " + b + " * " + c + " = " + product);
                                found = true;
                            }
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
