using System;
namespace Hel.CreatingTypesinC
{
    public class PracticingToString
    {
        public static void Program()
        {
            //ToString object method 
            int x = 1;
            string a = x.ToString();
            Console.WriteLine(a); //1

            Panda p = new Panda("Alex");
            Console.WriteLine(p); // Alex is a happy panda 
        }

        public class Panda
        {
            public string Name;

            public Panda(string Name)
            {
                this.Name = Name;
            }
            //overriding ToString
            public override string ToString() => Name + " is a happy panda";
        }
    }
}

//ToString method in C#
//returns the default textual representation of a type instance
//Very common to override this method in custom classes: flexible outputs when printing reference types