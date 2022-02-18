using System;
using System.Collections.Generic;
using System.Text;

namespace GenericParameters
{
    public class Employee : Person
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
