using System;

namespace Hel.ClanguageBasics
{
    class NullOperators
    {
        //private int x = 8;

        private void Method()
        {
            Console.WriteLine("Hell");
        }

        public static void Program()
        {
            //null coalescing operator ?? 
            //NullOperators nullClass = null;
            //NullOperators @class = new `NullOperators();
            //NullOperators newClass = nullClass ?? @class;

            //Console.WriteLine(newClass.x);

            ////------––---------------------------------------
            ////null-coalescing assignment operator ??=
            //NullOperators nullClass = null;
            //NullOperators @class = new NullOperators();
            //nullClass ??= @class; //replaces the normal 'if null' statement

            //NullOperators newClass = new NullOperators();
            //newClass.x = 10;
            //nullClass ??= newClass;

            //Console.WriteLine(nullClass.x);
            //nullClass.x = 20;
            //Console.WriteLine(nullClass.x);
            //Console.WriteLine(@class.x);

            ////------––---------------------------------------
            //null conditional operator .?
            NullOperators nullClass = null;
            NullOperators @class = new NullOperators();

            nullClass?.Method(); // b/c nullClass is set to null, do not try
                                 // to call method, short circuits the rest of the method
            @class.Method();
        }
    }
}
