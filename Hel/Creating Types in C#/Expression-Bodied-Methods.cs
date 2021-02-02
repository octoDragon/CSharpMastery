using System;
namespace Hel.CreatingTypesinC
{
    public class Expression_Bodied_Methods
    {
        int y = 10;
        //expression-bodied method example, works with up too one statement after method decleration
        
        public static void Program()
        {
            //int sumf(float x) => x + y; //will return an error because the method is implicitly static,
                                          //not allowing it too see the variables of the enclosing type
            int sum(int x) => x + x; //example of a local method
            Console.WriteLine(sum(9)); //prints 18
        }
    }
}
