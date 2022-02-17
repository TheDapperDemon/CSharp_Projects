using System;

namespace Polymorphism_InC_Sharp
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
            IQuittable Terminated = new Employee();
            Terminated.Quit("Jonah");
        }
        
    

    }
}
