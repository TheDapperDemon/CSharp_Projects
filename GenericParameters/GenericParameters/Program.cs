using System;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Jonah = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            Console.ReadLine();
        }

        //Player<Card> player = new Player<Card>();
        //player.Hand = new List<Card>();
    }
}
