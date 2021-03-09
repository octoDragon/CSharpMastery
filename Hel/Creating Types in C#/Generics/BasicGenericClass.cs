using System;
namespace Hel.CreatingTypesinC
{
    public class BasicGenericClass
    {
        //Generic Stack Class
        public class Stack<G>
        {
            int position;
            public int count = 0;
            G[] data = new G[100]; //size 100
            public void Push(G obj)
            {
                count++;
                data[position++] = obj;
            }
            public G Pop()
            {
                count--;
                if (count >= 0) { return data[--position]; }
                else throw new ArgumentException("Stack is Empty, cannot Pop");
            }
        }

        public static void Program()
        {
            var s = new Stack<int>();
            s.Push(1);
            s.Push(2); 
            s.Push(3);
            //print stack
            for (int i = s.count; i > 0; i--)
            {
                Console.WriteLine(s.Pop()); // 3 2 1 
            }
        }
    }
}
