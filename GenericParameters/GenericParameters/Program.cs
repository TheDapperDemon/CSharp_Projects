using System;
using System.Collections.Generic;
using System.Linq;

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

            Employee<int> ID = new Employee<int>
            {
                Things = new List<int>()
            };
            ID.Things.Add(101);
            ID.Things.Add(102);
            ID.Things.Add(103);

            //for (int i = 0; i < 104; i > 100;) 
            
            foreach (string n in Name.Things)
            {
                Console.WriteLine(n);
            };
            foreach (int i in ID.Things)
            {
                Console.WriteLine(i);
            };
        }
    }
}
