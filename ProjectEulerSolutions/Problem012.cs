using System;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// </summary>
    class Problem012
    {
        public void run()
        {
            var watch = Stopwatch.StartNew();
            Helper MathHelper = new Helper();

            int triangleNumber = 0;
            int i = 1;

            while (MathHelper.NumberOfDivisors(triangleNumber) < 500)
            {
                triangleNumber += i;
                i++;
            }

            Console.Out.WriteLine("The first triange number with atleast 500 divisors is: " + triangleNumber);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
