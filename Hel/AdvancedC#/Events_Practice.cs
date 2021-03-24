using System;
namespace Hel.AdvancedCSharp
{
    public delegate float CalculateHandler(int x);
    public class Events_Practice
    {
        public static void Program() //"Main" method
        {
            Shop riverside = new Shop("Riverside"); //create a shop object
            Shop.Go_Shopping(riverside);
        }

    }

    public class Shop
    {
        //public event CalculateHandler calculate_cost;
        string name;
        float water_cost = 7f; //expensive water
        float total_cost = 0;
        //CalculateHandler c = <insert method here>;
        public float Price //property
        {
            get => total_cost; //read
            set {total_cost = (value*water_cost); } //value is amount of water bought //assigned
        }
        public Shop(string s)
        {
            name = s;
        }

        public float Discount(int p_off) //percent off
        {
            
            return Price*(p_off/100f);
        }
        //Shopping user expierience, generic for every shop
        public static void Go_Shopping(Shop shop)
        {
            //fields
            int n = 0; //number of water bottles bought
            int d = 0; //discount from coupon
            //Welcome to shop
            Console.WriteLine("Welcome to " + shop.name + "!");

            //How many items
            Console.WriteLine("Right now we are only selling water, so");
            Console.WriteLine("how man water bottles would you like?");
            n = Int16.Parse(Console.ReadLine());
            shop.Price = n; //calculate total price
            Console.WriteLine("Your price is: $" + shop.Price);

            //Total Price 
            Console.WriteLine("Oh! You have a discount from a coupon.");
            Console.WriteLine("How much percent off?");
            d = Int16.Parse(Console.ReadLine()); 

            CalculateHandler c = shop.Discount; //calculate discount delegate
            c(d);

            Console.WriteLine("Your discounted total price is: $" + shop.Price);
            //Goodbye
            Console.WriteLine("Have a nice day, the weather is beautiful out today!");
        }
    }
}