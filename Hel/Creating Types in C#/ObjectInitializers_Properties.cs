using System;
namespace Hel.CreatingTypesinC
{
    public class ObjectInitializers_Properties
    {
        public ObjectInitializers_Properties()
        {
        }


        public static void Program()
        {
            Table table0 = new Table();
            Table table1 = new Table("PierreOne", -1, -2);//explicit parameters
            Table table2 = new Table(b: "skldf", legNum: 8); //optional parameters
            Table table3 = new Table { Age = 9, Brand = "Target", LegNum = 8 }; //Object Initializer Example

            Console.WriteLine("Start: ");
            table0.PrintInfo();
            table1.PrintInfo();
            table2.PrintInfo();
            table3.PrintInfo();
            Console.WriteLine("End");
             
            return;
        }

        private class Table
        {
            public int LegNum;
            public double Age;
            public string Brand = "Walmart"; //default assignment

            public Table(string b = "N/A", int legNum = 0, double age = 0) //optional parameters
            {
                Brand = b;
                LegNum = legNum;
                Age = age;
            }

            public void PrintInfo()
            {
                Console.WriteLine("Table Information");
                Console.WriteLine(LegNum + " " + Age + " " + Brand);
                Console.WriteLine();
            }
        }
    }
}


/* EXAMPLE OUTPUT:
Start:
Table Information
0 0 N / A

Table Information
-1 -2 PierreOne

Table Information
8 0 skldf

Table Information
8 9 Target

End*/