using System;

namespace CallingMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do the math operations on");
            int answer = Convert.ToInt32(Console.ReadLine());
            Class1.Method1(answer);
            Class1.Method2(answer);
            Class1.Method3(answer);
        }
    }
}
