using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    public class Employee : Person
    {
        public int id { get; set; }

        public static bool operator ==(Employee Employee1, Employee Employee2)
        {
            return Employee1.id == Employee2.id;
        }
        public static bool operator !=(Employee Employee1, Employee Employee2)
        {
            return Employee1.id != Employee2.id;
        }
    }
}
