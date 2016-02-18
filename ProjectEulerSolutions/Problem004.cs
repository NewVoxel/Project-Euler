using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class Problem004
    {
        /// <summary>
        /// Returns true/false on whether the inputted number is symetrical or not
        /// </summary>
        /// <param name="num">Value to be check for symmetry</param>
        /// <returns>True if number is symetrical otherwise false</returns>
        private bool isPalindrome(long num)
        {
            bool isPalindrome = true;
            //Determine mid point of number to cancel loop when it's reached
            string numString = num.ToString();
            int midPoint = numString.Length / 2;
            //If the numbers on either end don't match as we progress inwards break early with false reading
            //Otherwise finish at the half way point with a true reading
            for(int i = 0; i < midPoint; i++)
            {
                if(numString[i] != numString[numString.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }

        public void run()
        {
            //Create a stopwatch to calculate how long program takes to execute
            var watch = Stopwatch.StartNew();

            //Variables to hold largest found palindrome and product of the two 3 digit numbers
            int largestPalindrome = 0;
            int product;
            /* Starting from the highest possible values iterate downwards and test products
             * to see if they're palindromes. If proudct is palindrome break inner loop early
             * since any other found palindrome for that iteration will be lower than the 
             * currently found one. */
            for(int i = 999; i > 0; i--)
            {
                for(int j = 999; j > 0; j--)
                {
                    product = i * j;
                    if(isPalindrome(product))
                    {
                        if(product > largestPalindrome)
                        {
                            largestPalindrome = product;
                            break;
                        }
                    }
                }
            }
            Console.Out.WriteLine("The largest palinedrome of any 3 digit product is : " + largestPalindrome);

            //Display time taken to execute program
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.Write("Program completed in : " + elapsedMs + "ms");
        }
    }
}
