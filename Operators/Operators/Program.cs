using System;

namespace Operators
{
   class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee()
            {
                id = 101
            };
            Employee Employee2 = new Employee()
            {
                id = 202
            };
            Console.WriteLine(Employee1 == Employee2);
            Console.ReadLine();
            //Employee Jonah = new Employee()
            //{
            //    FirstName = "Sample",
            //    LastName = "Student"
            //};
            //Jonah.SayName();
        }
    }
}
