using System;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// Base class used to access all of the solution files.
    /// In order to execute the required question run this program from the command prompt followed by the question number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Check if the user entered the question number as required
            if (args.Length == 0)
            {
                Console.Out.Write("You must enter in the question number you want solved!");
            }
            else
            {
                //Make sure the question number they entered is in the correct format
                try
                {
                    int num = Int32.Parse(args[0]);
                }
                catch (Exception ex)
                {
                    Console.Out.Write(ex.ToString());
                    Environment.Exit(0);
                }
                //Execute the code for the desired question by accessing the class containing the desired algorithm.
                int questionNum = Int32.Parse(args[0]);
                if(questionNum == 1)
                {
                    Problem001 problem = new Problem001();
                    problem.run();
                } else if (questionNum == 2)
                {
                    Problem002 problem = new Problem002();
                    problem.run();
                }
            }
        }
    }
}
