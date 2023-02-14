using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();

            // 3. Instantiate two objects of the Employee class + assign values to their properties
            // Then Compare the two Emplyoee objects using the newly overloaded operators + display the results

            // Assigns values to new Employee Class
            Employee employee1 = new Employee() { FirstName = "Brandon", LastName = "Roman", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Kristie", LastName = "Pham", Id = 2 };

            // Adds to list
            //employee1.Employees = new List<string>() { "Brandon" + "Roman" };
            employees.Add(employee1);
            employees.Add(employee2);

            // For each employee in employees, if IDs are the same, return if statement
            // Otherwise, return else statement
            foreach (Employee employee in employees)
            {
                // Using newly overloaded operators for if statement
                if (employee1.Id == employee2.Id)
                {
                    Console.WriteLine("These IDs are the same.");
                }
                // Returns else statement if previous statement was false
                else
                {
                    Console.WriteLine($"Employee Information: \n {employee.Id} {employee.FirstName} {employee.LastName}");
                }
            }
            Console.ReadLine();
        }
    }
}
