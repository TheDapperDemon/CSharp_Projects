using System;

namespace ConsoleAppPt3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 20;
            int B = 10;
            int C = 20;

            while (A>B)
            {
                Console.WriteLine("A wins!");
                B++;
            }
            Console.ReadLine();
            
            if (C>=A)
            {
                Console.WriteLine("C has caught  up!");
            }
            Console.ReadLine();

        }
    }
}
