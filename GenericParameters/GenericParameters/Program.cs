using System;
using System.Collections.Generic;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Name = new Employee<string>
            {
                Things = new List<string>()

            };
            Name.Things.Add("Jonah");
            Name.Things.Add("Jeff");
            Name.Things.Add("Hakon");
            Console.ReadLine();

            Employee<int> ID = new Employee<int>
            {
                Things = new List<int>()

            };
            ID.Things.Add(101);
            ID.Things.Add(202);
            ID.Things.Add(303);

        }
    }
}
