using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch myStopwatch = new StopWatch();
            bool goAgain = true;
            string response;

            while (goAgain)
            {
                Console.WriteLine("Selest S to start, C to Clear, and X to exit the press return. \n");
                response = Console.ReadLine();

                if ((response == "S") || (response == "s"))
                {
                    myStopwatch.SetStart();
                    Console.WriteLine("Press return again to Stop the timer\n");
                    Console.ReadKey();
                    myStopwatch.SetStop();
                    Console.WriteLine(myStopwatch.GetDuration().Hours + " hours, " +
                        myStopwatch.GetDuration().Minutes + " minutes, " +
                        myStopwatch.GetDuration().Seconds.ToString() +" seconds.\n");
                        
                }
                else if (response == "C" || response == "c")
                {
                    myStopwatch.ClearTime();
                }
                else if (response == "X" || response == "x")
                {
                    goAgain = false;
                }
                else
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("{0} is an invalid response. \n", response);
                    }
                }
            }
        }
    }
}
