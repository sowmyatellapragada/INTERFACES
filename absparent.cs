using System;

namespace ConsoleApp3
{
   abstract class absparent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void div(int x, int y);
       

    }
}
