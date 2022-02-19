using System;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>
            {
                Things = new List<string>()
            };
            employee.Things.Add("Jonah");
            employee.Things.Add("Jeff");
            employee.Things.Add("Hakon");
            
        }
    }
}
