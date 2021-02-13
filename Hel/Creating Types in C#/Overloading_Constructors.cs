using System;
namespace Hel.CreatingTypesinC
{
    public class Overloading_Constructors
    {
        public class Cheese
        {
            //fields
            private string n; //name
            private decimal w; //weight
            private float p; //price
            private string s; //seller 

            //constructors (overloading two different ways)
            public Cheese(string name)
            {
                n = name;
            }

            public Cheese(string name, decimal weight)
            {
                n = name;
                w = weight;
            }

            public Cheese(string name, decimal weight, float price, string seller) : this(name, weight)
                         { n = name; w = weight; p = price; s = seller; }

            //Overriding toString method
            public override string ToString()
            {
                if (w == default(decimal) && p == default(float) && s == default(string))
                {
                    return "Name: " + n + "\n";
                }

                if ((s == default(string) && p == default(float)))
                {
                    return "Name: " + n + "\n" +
                           "Weight: " + w + " grams\n";
                }

                // 2 more print statements

                else { return "Name: " + n + "\n" +
                              "Weight: " + w + " grams\n" +
                              "Price: " + p + " dollars\n" +
                              "Seller: " + s + "\n";
                }

            }

        }

        public static void Program()
        {
            Cheese cheese1 = new Cheese("Blue");
            Cheese cheese2 = new Cheese("Cheddar", 5m);
            Cheese cheese3 = new Cheese("Feta", 20m, 27.50f,"Cheesemonger");

            Console.WriteLine(cheese1);
            Console.WriteLine(cheese2);
            Console.WriteLine(cheese3);


            
        }




    }
}
