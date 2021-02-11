using System;
namespace Hel.CreatingTypesinC
{
    public class Using_Indexers
    {
        public class Sentence
        {
            public string[] words = "I love coffee".Split();

            public string this[int index, string arg2 = "(edited)"]
            {
                get => words[index];
                set => words[index] = value + arg2;
            }

        }

        public static void Program()
        {
            Sentence s = new Sentence();
            Console.WriteLine(s.words[2]); //coffee (without using indexer)
            Console.WriteLine(s[2]); //coffee (using indexer)
            s[2] = "June";
            Console.WriteLine(s[2]); //June
        }

    }
}
