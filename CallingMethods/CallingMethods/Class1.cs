using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Class1
    {
        public static void Method1(int A)
        {
          
            Console.WriteLine("Your answer plus ten is " +( A + 10));

        }
        public static void Method2(int A)
        {
            Console.WriteLine("Your answer times ten is " + (A * 10));
        }
        public static void Method3(int A)
        {
            Console.WriteLine("Your answer divided ten is " + (A / 10));
        }

    }
}
