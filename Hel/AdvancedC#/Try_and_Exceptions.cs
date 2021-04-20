using System;
namespace Hel.AdvancedCSharp
{
    public class Try_and_Exceptions
    {
        public static void Program()
        {
            Try_and_Exceptions TaE = new Try_and_Exceptions();
            TaE.DivideByX(0); //ERROR: attempted to divide by zero

        }

        public void DivideByX(int x)
        {
            try { int y = 9/x;}
            catch (DivideByZeroException ex)
            {
                System.Console.Write("ERROR: ");
                System.Console.WriteLine(ex.Message);
            }
            System.Console.WriteLine("Program has ended.");
        }
    }
}
