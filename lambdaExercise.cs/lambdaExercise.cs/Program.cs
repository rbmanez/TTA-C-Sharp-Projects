//PURPOSE:    Lambda expression exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExercise.cs
{
    class Program
    {
        //In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name,
        //as well as an Id. At least two employees should have the first name "Joe".
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.FirstName = "R";
            employee1.LastName = "M";
            employee1.Id = 1;
            employeeList.Add(employee1);

            Employee employee2 = new Employee();
            employee2.FirstName = "Ro";
            employee2.LastName = "Ma";
            employee2.Id = 2;
            employeeList.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Rob";
            employee3.LastName = "Man";
            employee3.Id = 3;
            employeeList.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Robe";
            employee4.LastName = "Mane";
            employee4.Id = 4;
            employeeList.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "Rober";
            employee5.LastName = "Manez";
            employee5.Id = 5;
            employeeList.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Robert";
            employee6.LastName = "Manez";
            employee6.Id = 6;
            employeeList.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "Robert";
            employee7.LastName = "M";
            employee7.Id = 7;
            employeeList.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "Joe";
            employee8.LastName = "Ma";
            employee8.Id = 8;
            employeeList.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Joe";
            employee9.LastName = "Man";
            employee9.Id = 9;
            employeeList.Add(employee9);

            Employee employee10 = new Employee();
            employee10.FirstName = "Robert";
            employee10.LastName = "Mane";
            employee10.Id = 10;
            employeeList.Add(employee10);

            //Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> employeeList2 = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    employeeList2.Add(employee);
                }
            }

            //Do the same thing again, but this time with a lambda expression.
            List<Employee> employeeList3 = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> employeeList4 = employeeList.Where(x => x.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}
