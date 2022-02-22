using System;

namespace ParsingEnums
{
    class Program : Days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the current day of the week");
            string value = Console.ReadLine();
            Days Day = (Days)Enum.Parse(typeof(Day), value);
            //answer = Convert.ToInt32();
        }
    }
}
