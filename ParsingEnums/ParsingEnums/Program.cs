using System;

namespace ParsingEnums
{
    class Program : Days
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday 
        };
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please type the current day of the week");
                string answer = Console.ReadLine();
                Day Jonah = (Day)Enum.Parse(typeof(Day), answer);
                Console.WriteLine("Todays day is " + Jonah);
            }
            catch
            {
                Console.WriteLine("Please enter a valid day of the week");
                Console.ReadLine();
            }
            //answer = Convert.ToInt32();
        }
    }
}
