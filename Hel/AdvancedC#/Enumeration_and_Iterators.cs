using System;
using System.Collections;
namespace Hel.AdvancedCSharp
{
    public class Enumeration_and_Iterators
    {
        public static void Program()
        {
            foreach(string f in Foo(true))
            {
                 
            }
        }

        static IEnumerable Foo(bool breakEarly)
        {
            yield return "One";
            yield return "Two";

            if (breakEarly) yield break;

            yield return "Three";
        }

        static IEnumerator MyEnumerator(int i, string s)
        {
            i++;
            yield return i + " character: " + s;
        }
    }

    // class MyEnumerator : IEnumerator
    // {
    //     public string Current
    //     {
    //         get { return Current; }
    //     }
    //     public bool MoveNext()
    //     {

    //     }
    // }
}
