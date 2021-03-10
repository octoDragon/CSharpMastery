using System;

namespace Hel.AdvancedCSharp
{
    //Delegate
    public delegate void Progress (int x);
    public class Delegate_Multicast
    {
        //Class to Run
        public static void Program()
        {
            Progress p = PrintToConsole; //delegate pt 1.
            p += PrintToFile; //delegate pt 2. 
            Take_a_long_time(p);
        }
        public static void Take_a_long_time(Progress p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i*10); //show progress
                System.Threading.Thread.Sleep(200); //add a delay
            }
            Console.WriteLine("Complete.");
        }

        static void PrintToConsole(int x) => Console.WriteLine(x);
        static void PrintToFile(int x) => 
            System.IO.File.WriteAllText("output.txt", x.ToString());
    }
}