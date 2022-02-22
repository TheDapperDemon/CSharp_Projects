using System;

namespace LamdaExpressions
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            new Employees() { firstName = "Joe", lastName = "Smith", empID = 10 };
            new Employees() { firstName = "Joe", lastName = "Gonzolaz", empID = 20 };
            new Employees() { firstName = "Jonah", lastName = "Diaz", empID = 30 };
            new Employees() { firstName = "Jeff", lastName = "Arnold", empID = 40 };
            new Employees() { firstName = "Ryan", lastName = "Bunker", empID = 50 };
            new Employees() { firstName = "Wes", lastName = "Anderson", empID = 60 };
            new Employees() { firstName = "Mark", lastName = "Cuban", empID = 70 };
            new Employees() { firstName = "Fidel", lastName = "Castro", empID = 80 };
            new Employees() { firstName = "Vlad", lastName = "Putt", empID = 90 };
            new Employees() { firstName = "Tony", lastName = "DelVizo", empID = 101 };

            
            foreach (var employees in Employees)
            {
                if(employees.firstName == "Joe")
                {
                    Employees employeeJoe = new Employees();
                    Joes.Add(employees);
                }
            }

        }
    }
}
