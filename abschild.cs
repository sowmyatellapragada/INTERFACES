using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class abschild:absparent

    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            abschild c = new abschild();
            absparent p = c;
            p.Add(100, 100);p.sub(50, 50);p.Mul(10, 2);p.div(10, 2);
        }


    }
}
