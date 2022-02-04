using System;

namespace DoubleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Pinaple = new Class1();




            Console.WriteLine("Please enter a number to be used in the program");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Please enter a second number to be used in the program. NOT REQUIRED");
                int answer2 = Convert.ToInt32(Console.ReadLine());
                int result = Pinaple.Method1(answer1, answer2);
                Console.WriteLine("Your two numbers ran through the program return " + result);
            }
            catch
            {
                int result = Pinaple.Method1(answer1);
                Console.WriteLine("The result of your number is " + result);
                Console.ReadLine();
            }
        }
    }
}
