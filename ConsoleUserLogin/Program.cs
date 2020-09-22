using System;
using System.Collections.Generic;

namespace ConsoleUserLogin
{
    /*
     *  This is not our main focus for this Code show 
     * 
     */

    public class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                StartMenu();
                //More code needed
            }
        }

        //More methods needed

        static void StartMenu()
        {
            Console.WriteLine("Welcome to the user login program!\n\nType in one of the following options:\nlogin\nquit\n\n");
        }

        static string AskUserFor(string what)
        {
            Console.Write("Please enter {0}: ", what);
            return Console.ReadLine();
        }
    }
}
