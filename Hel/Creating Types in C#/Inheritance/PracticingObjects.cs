using System;
namespace Hel.CreatingTypesinC
{
    public class PracticingObjects
    {
        public PracticingObjects()
        {
        }

        public static void Program()
        {
            int x = 6;
            Object object1 = x; //boxing
            int y = (int)object1; //unboxing

            Console.WriteLine(object1); //6 
            Console.WriteLine(y); //6 
        }
    }
}

//Practicing Using Objects in C#
//System.Object is the ultimate base class;
//Demonstrates type unification in the form of boxing and unboxing
//Boxing: value-type --> reference-type
//Unboxing: reference-type --> value-type (requires explicit cast)