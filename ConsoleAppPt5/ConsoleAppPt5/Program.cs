using System;
using System.Collections.Generic;

namespace ConsoleAppPt5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>() { "cat", "dog", "bird", "cat" };
            Console.WriteLine("enter an animal to search list");
            string answer = Console.ReadLine();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == answer)
                {
                    Console.WriteLine(answer + " is on List!");
                }
                else
                {
                    Console.WriteLine(answer + " is not on List");
                }

            }
            Console.ReadLine();
        }
    }
    
}
