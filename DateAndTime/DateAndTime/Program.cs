using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current Date and Time is " + DateTime.Now);
            Console.WriteLine("Please enter a number (x) to be added to the Current Time in hours");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The time in x hours from now will be " + DateTime.Now.AddHours(X));
            Console.ReadLine();
        }
    }
}
