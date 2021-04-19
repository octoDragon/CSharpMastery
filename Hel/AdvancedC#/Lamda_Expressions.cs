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

            //lamda expression instantiation
            Func<int, bool> IsInputOne = x => x == 1;
            le.ex4(IsInputOne, 1); //true
            le.ex4(IsInputOne, 4); //false
            le.ex5("Hello Everyone!"); //Hello Everyone!

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
        //Func<input,return> Delegate Type
        public void ex3()
        {
            Func<int,int> sqr = x => x * x;
        }
        //Delegate as input parameter
        public void ex4(Func<int,bool> predicate, int input)
        {
            int Input = input;
            System.Console.WriteLine(predicate(input));
        }
        //Action<T> Delegate Type
        public void ex5(string my_word)
        {
            Action<string> PrintTheString = my_string => Console.WriteLine(my_string); 
            PrintTheString(my_word);
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