//using System;
//namespace Hel.CreatingTypesinC
//{
//    //NOT COMPLETE YET
//    public class InterfacePractice : MyShopInterface
//    {
//        //fields
//        private float Total = 0f;
//        //private object Item;
//        struct Item
//        {

//        }
            
//        private object[] Inventory;



//        //running
//        public static void Program()
//        {
//            bool IsShopping = true;
//            InterfacePractice Maridian = new InterfacePractice();
//            while (IsShopping)
//            {
//                //Buy the selected item
//                Maridian.Buy(Maridian.Select()); 
//            }
//            Maridian.TotalCost();
//            Maridian.Exit();
//        }

//        //methods
//        public object Select()
//        {
//            Console.WriteLine("What would you like?");
//            Console.WriteLine("[1]Elk Meat");
//            Console.WriteLine("[2]Glacier Water");
//            Console.WriteLine("[3]Gun Poweder");
//            Console.WriteLine("[4]Tar");
//            Console.WriteLine("[9]EXIT");
//            Item = Int16.Parse(Console.ReadLine()); //boxing 
//            //food selection
//            switch (Item)
//            {
//                case 1:
//                    Console.WriteLine();
//                    break;
//                case 2:
//                    //do something
//                    break;
//                case 3:
//                    //do something
//                    break;
//                case 4:
//                    //do something
//                    break;
//                case 9:
//                    //EXIT
//                    break;
//            }
//            return Item;
//        }

//        public float Buy(object item)
//        {
//            return Total;
//        }

//        public void Exit()
//        {

//        }

//        private void TotalCost() => Console.WriteLine("TotalCost: " + Total);
//    }

//    public interface MyShopInterface
//    {
//        object Select();
//        float Buy(object item);
//        void Exit();
//    }
//}
