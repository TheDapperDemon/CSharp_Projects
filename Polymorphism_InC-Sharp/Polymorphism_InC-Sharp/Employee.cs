using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_InC_Sharp
{
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit(string name)
        {
            Console.WriteLine(name + " I Quit");
        }
    }
}
