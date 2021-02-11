using System;
namespace Hel.CreatingTypesinC
{
    public class Using_Properties
    {
        public static void Program()
        {
            Store store1 = new Store { streetname = "Westbrook" };
            Console.WriteLine("You are at a store in " + store1.Location);
            Console.Write("Would you like to buy something? (Y/N): ");
            store1.response = Console.ReadLine();
            if (store1.response == "Y") { store1.Shopping(store1); }
            else { Console.WriteLine("Bonne Journée!"); }
        }
    }

    public class Store
    {
        //Fields
        public string response;
        public string streetname;
        public int numberOfApples = 0;
        public int numberOfOranges = 0;
        public int numberOfBannanas = 0;

        private string city = "London"; //private "backing" field
        private int zipCode = 12345;
        private double applePrice = 2.99;
        private double orangePrice = 0.99;
        private double bannanaPrice = 3.99;
        private double totalCost = 0;

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

        //Constructor
        public Store()
        {
        }

        //Methods
        public void Shopping(Store store)
        {
            do
            {
                Console.WriteLine("What would you like to buy, \n" +
                    "Bannanas (1), Apples (2), or Oranges (3)");
                store.response = Console.ReadLine();
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
                Console.WriteLine("Would you like anything else? (Y/N): ");
                store.response = Console.ReadLine();
                Console.WriteLine("reponse: " + store.response);
            } while (!store.response.Equals("N") || !store.response.Equals("n")); //TODO Fix this logic, not reading it???

            Console.WriteLine("Your total cost is: " + store.TotalCost);
        }

        private static int Amount(Store store) //How many?
        {
            Console.WriteLine("How many would you like?: ");
            store.response = Console.ReadLine(); // need to parse string to int
            return Int32.Parse(store.response);
        }


    }
}
