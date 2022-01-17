using System;
using System.Collections.Generic;

namespace ConsoleAppPt4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>() { "black", "purple", "orange", "blue"};
            Console.WriteLine("enter a color to search list");
            string answer = Console.ReadLine();
                 for (int i = 0; i < colors.Count; i++)
            {
                if (colors [i] == answer )
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
