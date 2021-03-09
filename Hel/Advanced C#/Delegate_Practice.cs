using System;
namespace Hel.AdvancedCSharp{
delegate int Transfomer (int x); 
    public class Delegate_Practice
    {
        public static void Program()
        {
            Transfomer t = Square;
            Console.Write("Enter a numer:");
            int x = Int16.Parse(Console.ReadLine());
            int y = t(x);
            Console.WriteLine(x + " squared " + y); //81

        }
         static int Square (int x) => x * x;

    }
}