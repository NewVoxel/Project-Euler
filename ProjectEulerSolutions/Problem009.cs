using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    class Problem009
    {
        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
