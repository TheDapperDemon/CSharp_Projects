﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {
        public int id { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
