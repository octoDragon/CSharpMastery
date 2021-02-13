using System;
namespace Hel.CreatingTypesinC
{
    public class Using_Inheritance
    { 
        public static void Program()
        {
            Books.Crimi crimi = new Books.Crimi();
            crimi.name = "CSI"; crimi.detective = "Gibs";
            crimi.victum = "John"; crimi.author = "Alys";
            Books.Fantasy fantasy = new Books.Fantasy();
            fantasy.name = "DragonPrince"; fantasy.dragon = "Lung";
            fantasy.princess = "Fiona"; fantasy.author = "Hans";

            //Console.WriteLine(crimi.name + " " + crimi.detective + " " + crimi.victum);
            //Console.WriteLine(fantasy.name + " " + fantasy.dragon + " " + fantasy.princess);

            DisplayAuthor(crimi);
            DisplayAuthor(fantasy);
        }

        private static void DisplayAuthor(Books book) //instance of polymorphism
        {
            Console.WriteLine(book.name + "'s author: " + book.author);
        }

        public class Books
        {
            public string name;
            public string author;

            public class Crimi : Books //inherits from Books
            {
                public string detective;
                public string victum;
            }

            public class Fantasy : Books //inherits from Books
            {
                public string dragon;
                public string princess;
            }

        }
    }
} 
