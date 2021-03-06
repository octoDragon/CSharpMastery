using System;
namespace Hel.CreatingTypesinC
{
    public class EnumConversions
    {
        public static void Program()
        {
            //enum -> int conversion
            int i = (int)BoxSides.Top;
            Console.WriteLine(i);
            i = 3; //reasigning i 

            //int -> enum conversion
            BoxSides side = (BoxSides)i;
            Console.WriteLine(side); //Left

            //Q:Out of bounds?
            side = (BoxSides)9; //doesn't exist in my enum
            Console.WriteLine(side); //9

            //Q:Loop through an enum?
            BoxSides box = new BoxSides();
            for (int k = 0; k < (int)BoxSides.Last; k++)
            {
                Console.WriteLine("member name: " +
                    (box+k) + " " + ((int)box+k));
            }

            //Q:Differentiate between members?
            side = (BoxSides)2;
            //true if 2 | 3
            bool leftorRight = ((int)side == (int)BoxSides.Right ||
                                (int)side == (int)BoxSides.Left);
            Console.WriteLine(leftorRight); //true
        }
        public enum BoxSides { Default=0, Top, Right, Left, Bottom, Last = Bottom+1 }
    }
}
