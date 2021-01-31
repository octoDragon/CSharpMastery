using System;

namespace Hel.ClanguageBasics
{
    public class Switches
    {
        static int x = -2;

        public static void Program()
        {
            switch (x){
                case -2:
                case -1:
                case 0:
                    x++; Console.WriteLine($"x is now equal to {x}"); goto case 1;
                case 1:
                    x++; Console.WriteLine($"x is next incremented to {x}"); goto case 2;
                case 2:
                    x++; Console.WriteLine($"x is finally equal to {x}"); goto case 3;
                case 3:
                    break;
            }
        }
    }
}
