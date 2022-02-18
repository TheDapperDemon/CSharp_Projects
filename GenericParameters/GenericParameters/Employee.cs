using System;
using System.Collections.Generic;
using System.Text;

namespace GenericParameters
{
    public class Employee<T> : Person
    {
        public new List<T> FirstName{ get; set; }
        public new List<T> LastName { get; set; }

        public void Quit(string name)
        {
            Console.WriteLine(name + " I Quit");
        }
    }
}
