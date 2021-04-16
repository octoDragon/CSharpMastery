using System;
namespace Hel.AdvancedCSharp
{
    //lamda expression is an unnamed method written in place 
    //of a delegate instance
    public class Lamda_Expressions
    {
        delegate int Transformer (int i);
        delegate int Double_Transformer (int i, int j);

        public static void Program()
        {
            Lamda_Expressions le = new Lamda_Expressions();
            le.ex1(); // 9
            le.ex2(); //100

        }
        //single parameter lamda expression
        public void ex1()
        {
            Transformer sqr = x => x * x; 
            System.Console.WriteLine(sqr(3)); //9
        }
        //multiple parameters lamda expression
        public void ex2() 
        {
            Double_Transformer multiply = (x, y) => x * y;
            System.Console.WriteLine(multiply(50,2)); //100
        }
        //TODO look into Func<> and Action<> Delegates
        public void ex3()
        {

        }
    }
}

//Questions: 
//Q: does it only work with one 
//   line methods? 
//Q: why are lamda expressions useful
//   <slash> why would I want to define 
//   a delegate instead of defining a method?
//Q: 