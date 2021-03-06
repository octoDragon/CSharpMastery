using System;
namespace Hel.CreatingTypesinC
{
    public class AccessModifierPractice
    {
        //public

        //private (default for members of class/struct)
        class Subclass1 { }

        //internal (must access from current assembly or friend assembly
        //with AccessModifierPractice.Subclass2)
        internal class Subclass2 { }

        //protected (containging class or subclass)
        protected class Subclass3 { }


        //protected internal > union of protected and internal

        //private protected > intersection of protected and internal
        //less accesible than private or protected alone

        public static void Program()
        {
            Subclass2 sc2 = new Subclass2();

        }
        
    }

    //internal by default (non nested type) 
    class Foo { }
}
