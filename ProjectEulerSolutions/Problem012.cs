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

            double triangleNumber = 1;
            double naturalNumber = 1;
            int factorCounter = 0;

            while(true)
            {
                factorCounter = 0;
                for(int i = 1; i <= triangleNumber; i++)
                {
                    if (triangleNumber % i == 0)
                        factorCounter++;
                }
                if (factorCounter >= 200)
                    break;
                naturalNumber++;
                triangleNumber += naturalNumber;
            }
            Console.Out.WriteLine("The first triangle number with at least 500 factors is: " + triangleNumber);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
