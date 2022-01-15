using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Your Name is: ", "Your Age is: ", "Your Height is: "};
            Console.WriteLine("What is your Name?");
            string answer = Console.ReadLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += answer;
                Console.WriteLine(stringArray[i]);
            } 
            Console.ReadLine();
        }
    }
}
