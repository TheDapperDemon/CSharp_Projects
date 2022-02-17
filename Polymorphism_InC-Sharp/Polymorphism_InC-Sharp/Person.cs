using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_InC_Sharp
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void SayName();
    }
}
