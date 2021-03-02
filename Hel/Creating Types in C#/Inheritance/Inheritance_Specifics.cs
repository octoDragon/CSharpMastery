using System;
namespace Hel.CreatingTypesinC
{
    public class Inheritance_Specifics
    {

        public static void Program()
        {
            //testing up and down casting
            Bathroom bathroom1 = new Bathroom { name = "Grandma's House", SinkCount = 4 };
            BedRoom bedroom1 = new BedRoom { name = "Home", BedCount = 2};

            House newHouse = bathroom1; //Upcast
            //Console.WriteLine(newHouse == bathroom1);

            //testing 'as'
            House h = new House();
            BedRoom b = h as BedRoom; // no esception thrown, be is null
            //b2 = (BedRoom)h; //exception thrown

            //testing virtual function members
            House h2 = new House();
            Console.WriteLine(h2.hasKitchen); //false
            Kitchen k = new Kitchen();
            Console.WriteLine(k.hasKitchen); //true, overriding virutal function member

            //testing abstract classes
            //Asset a = new Asset(); //syntax-error, can't instantiate an abstract class
            Stock s = new Stock();
            s.CurrentPrice = 900;
            s.SharesOwned = 20;
            Console.WriteLine(s.NetValue);





        }

        //Method(s)
        public static void Display(House house)
        {
      
            Console.WriteLine(house.name);
        }

        //Subsclasses
        public class House
        {
            public virtual bool hasKitchen => false;
            public string name;
        }

        public class Bathroom : House
        {
            public int SinkCount;
        }

        public class BedRoom : House
        {
            public int BedCount;
        }

        public class Kitchen : House
        {
            public override bool hasKitchen => true;
        }

        public abstract class Asset
        {
            public abstract decimal NetValue { get; } //abstract member
        }

        public class Stock : Asset
        {
            public long SharesOwned;
            public decimal CurrentPrice;

            //overridel ike a virtual method 
            public override decimal NetValue => SharesOwned * CurrentPrice;
        }
    }
}
