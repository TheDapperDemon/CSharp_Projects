using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpressions
{
   public class Program : Employee
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {

                new Employee() { firstName = "Joe", lastName = "Smith", empID = 10 },
                new Employee() { firstName = "Joe", lastName = "Gonzolaz", empID = 20 },
                new Employee() { firstName = "Jonah", lastName = "Diaz", empID = 30 },
                new Employee() { firstName = "Jeff", lastName = "Arnold", empID = 40 },
                new Employee() { firstName = "Ryan", lastName = "Bunker", empID = 50 },
                new Employee() { firstName = "Wes", lastName = "Anderson", empID = 60 },
                new Employee() { firstName = "Mark", lastName = "Cuban", empID = 70 },
                new Employee() { firstName = "Fidel", lastName = "Castro", empID = 80 },
                new Employee() { firstName = "Vlad", lastName = "Putt", empID = 90 },
                new Employee() { firstName = "Tony", lastName = "DelVizo", empID = 101 },
            };


            List<Employee> JoeList = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.firstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }
            List<Employee> lambdaJoeList = Employees.Where(e => e.firstName == "Joe").ToList();
            
            foreach(Employee employee in lambdaJoeList)
            {
                Console.WriteLine(employee.firstName = " 2nd list");
            }

        }
    }
}
