using System;

namespace CallingMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do the math operations on");
            int answer = Convert.ToInt32(Console.ReadLine());
            
           
            Class1.Method3(answer);
            int returnValue = Class1.Method1(answer);
            Console.WriteLine("Your Answer plus ten is " + returnValue);
            int returnValue2 = Class1.Method2(returnValue);
            Console.WriteLine("Your last Answer times ten is " + returnValue2);
            int returnValue3 = Class1.Method3(returnValue2);
            Console.WriteLine("Your last Answer divided by ten is " + returnValue3);

        }
    }
}
