using System;
using System.Collections.Generic;

namespace ConsoleAppPt7
{
    
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> Integers = new List<int>() { 35, 15, 25, 95 };
                Console.WriteLine("Please enter a number to be divide by each number in the list");
                int answer = Convert.ToInt32(Console.ReadLine());
           
                foreach (int i in Integers)
                {
                    Console.WriteLine(i / answer);
                }
                Console.ReadLine();
            }
           catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.WriteLine("Try Catch Block has been Executed");
            Console.ReadLine();
            
        }
    }
}
