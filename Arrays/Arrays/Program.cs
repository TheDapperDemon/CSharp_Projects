using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Your Name is: ", "Your Ageis: ", "Your Height is: ", "Your Favorite Color is: "};
            Console.WriteLine("What is your Name?");
            string answer = Console.ReadLine();
            Console.WriteLine(stringArray [1], answer);
            Console.ReadLine();
        }
    }
}
