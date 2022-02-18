using System;

namespace Operators
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
