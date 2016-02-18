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
                switch(questionNum)
                {
                    case 1:
                        Problem001 problem001 = new Problem001();
                        problem001.run();
                        break;
                    case 2:
                        Problem002 problem002 = new Problem002();
                        problem002.run();
                        break;
                    case 3:
                        Problem003 problem003 = new Problem003();
                        problem003.run();
                        break;
                    case 4:
                        Problem004 problem004 = new Problem004();
                        problem004.run();
                        break;
                    default:
                        Console.Out.WriteLine("The question number you entered does not exist!");
                        break;
                }
            }
        }
    }
}
