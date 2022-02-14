using System;

namespace Methods_and_Objects
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
            Jonah.SayName();
            Console.ReadLine();
        }
    }
}
