using System;
using System.Collections.Generic;

namespace ConsoleAppPt6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>() { "black", "purple", "orange", "blue", "brown", "green", "red", "blue" };
            Console.WriteLine("enter a color to search list");
            string answer = Console.ReadLine();
            int Counter = 0;
                foreach (string i in colors)
                    {
                    if (i == answer)
                            
                            {
                            if (Counter == 0)
                            { 
                            Console.WriteLine(answer + " is on List!");
                            Counter++;
                            }
                            else
                            {
                             Console.WriteLine(answer + " is on list but has already been found");
                            }
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
