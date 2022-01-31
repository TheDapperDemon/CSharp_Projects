using System;

namespace MainMethod
{
     class Program
    {
        static void Main(string[] args)
        {
            Class1 Purple = new Class1();
            Console.WriteLine(Purple.Method1(10));
            Console.WriteLine(Purple.Method1(.5m));
            Console.WriteLine(Purple.Method1("5"));
            Console.ReadLine();
        }
        
    }
}
