﻿using System;

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
                    case 5:
                        Problem005 problem005 = new Problem005();
                        problem005.run();
                        break;
                    case 6:
                        Problem006 problem006 = new Problem006();
                        problem006.run();
                        break;
                    case 7:
                        Problem007 problem007 = new Problem007();
                        problem007.run();
                        break;
                    case 8:
                        Problem008 problem008 = new Problem008();
                        problem008.run();
                        break;
                    case 9:
                        Problem009 problem009 = new Problem009();
                        problem009.run();
                        break;
                    case 10:
                        Problem010 problem010 = new Problem010();
                        problem010.run();
                        break;
                    case 11:
                        Problem011 problem011 = new Problem011();
                        problem011.run();
                        break;
                    case 12:
                        Problem012 problem012 = new Problem012();
                        problem012.run();
                        break;
                    default:
                        Console.Out.WriteLine("The question number you entered does not exist!");
                        break;
                }
            }
        }
    }
}
