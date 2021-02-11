using System;
namespace Hel.CreatingTypesinC
{
    public class Using_Properties
    {
        public static void Program()
        {
            //store declaration
            Store store1 = new Store { streetname = "Westbrook" };

            //store dialogue beginning
            Console.WriteLine("You are at a store in " + store1.Location);
            Console.Write("Would you like to buy something? (Y/N): ");
            store1.response = Console.ReadLine();

            //shopping
            if (store1.response == "Y") { store1.Shopping(store1); }
            //leaving
            else { Console.WriteLine("Bonne Journée!"); }
        }
    }

    public class Store
    {
        //Pulbic Fields
        public string response;
        public string streetname;
        public int numberOfApples = 0;
        public int numberOfOranges = 0;
        public int numberOfBannanas = 0;

        //Private Backing Fields
        private string city = "London";
        private int zipCode = 12345;
        private double applePrice = 2.99;
        private double orangePrice = 0.99;
        private double bannanaPrice = 3.99;

        //Properties
        public string Location
        {
            get {return streetname + ", " + city; }
            set { Location = value; } //'value' is an implicit parameter from 'get'
        }

        public int ZipCode 
        {
            get { return zipCode ; } //read only property
        }

        public double Apples //expression bodied statement 
        {
            get => applePrice * numberOfApples;

        }

        public double Oranges //expression bodied statement 
        {
            get => orangePrice * numberOfOranges;

        }

        public double Bannanas //expression bodied statement 
        {
            get => bannanaPrice * numberOfBannanas;

        }
        public double TotalCost
        {
            get { return Bannanas + Oranges + Apples; }
        }

        //Methods
        public void Shopping(Store store)
        {
            do
            {
                Console.WriteLine("What would you like to buy, \n" +
                    "Bannanas (1), Apples (2), or Oranges (3)");
                store.response = Console.ReadLine();

                //different food types, adds to the total amounts, calculates after shopping is complete
                switch (store.response)
                {
                    case "Bannanas":
                    case "bannanas":
                    case "1":
                        store.numberOfBannanas += Amount(store); break;
                    case "Apples":
                    case "apples":
                    case "2":
                        store.numberOfApples += Amount(store); break;
                    case "Oranges":
                    case "oranges":
                    case "3":
                        store.numberOfApples += Amount(store); break;
                    default:
                        Console.WriteLine("We do not sell that! Sorry!");
                        break;
                }
                Console.WriteLine("Would you like anything else? (Yes/No): ");
                store.response = Console.ReadLine();
            } while (store.response == "Yes" || store.response == "yes"); //TODO Fix this logic, not reading it???

            //Output / Money Owed / Total Cost
            Console.WriteLine("Your total cost is: $" + store.TotalCost);
            Console.WriteLine("(Press the enter key to exit)");
            Console.ReadLine(); //enter closes the program 
            
        }

        private static int Amount(Store store) //How many?
        {
            Console.WriteLine("How many would you like?: ");
            store.response = Console.ReadLine(); // need to parse string to int
            return Int32.Parse(store.response);
        }


    }
}

/*Example Output: 
You are at a store in Westbrook, London
Would you like to buy something? (Y/N): Y
What would you like to buy,
Bannanas (1), Apples (2), or Oranges (3)
1
How many would you like?:
1
Would you like anything else? (Yes/No):
Yes
What would you like to buy,
Bannanas (1), Apples (2), or Oranges (3)
1
How many would you like?:
1
Would you like anything else? (Yes/No):
Yes
What would you like to buy,
Bannanas (1), Apples (2), or Oranges (3)
2
How many would you like?:
1
Would you like anything else? (Yes/No):
No
Your total cost is: $10.97
(Press the enter key to exit)

 */