using System;
namespace Hel.CreatingTypesinC
{
    public class AccessModifierPractice
    {
        //public

        //private (default for members of class/struct)
        class Subclass1 { }

        //internal (must access from current assembly
        //with AccessModifierPractice.Subclass2)
        internal class Subclass2 { }

        //protected
        protected class Subclass3 { }


        //protected internal

        //private protected

        public static void Program()
        {
            Subclass2 sc2 = new Subclass2();

        }
        
    }

    //internal by default (non nested type) 
    class Foo { }
}
