using System;
using System.Collections.Generic;
using System.Text;

namespace GenericParameters
{
    public class Employee<T> : Person
    {
         public List<T> Things { get; set; }
         public string Name { get; set; }
         public int ID { get; set; }
         

        //public void Quit(string name)
        //{
        //    Console.WriteLine(name + " I Quit");
        //}
    }
}
