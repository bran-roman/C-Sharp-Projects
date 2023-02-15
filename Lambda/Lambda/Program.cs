using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 2. Create list of at least 10 employees with two using same name "Joe"
            // Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Roman" });
            employees.Add(new Employee() { Id = 2, FirstName = "Joe", LastName = "West" });
            employees.Add(new Employee() { Id = 3, FirstName = "Brandon", LastName = "Jane" });
            employees.Add(new Employee() { Id = 4, FirstName = "Gillian", LastName = "Nguyen" });
            employees.Add(new Employee() { Id = 5, FirstName = "Bruce", LastName = "Kim" });
            employees.Add(new Employee() { Id = 6, FirstName = "Chris", LastName = "Tran" });
            employees.Add(new Employee() { Id = 7, FirstName = "Nat", LastName = "Le" });
            employees.Add(new Employee() { Id = 8, FirstName = "Tina", LastName = "Park" });
            employees.Add(new Employee() { Id = 9, FirstName = "Ryan", LastName = "Higa" });
            employees.Add(new Employee() { Id = 10, FirstName = "Valky", LastName = "Rae" });

            //Employee employee1 = new Employee() { Id = 1, FirstName="Joe", LastName="Roman" };
            //Employee employee2 = new Employee() { Id = 2, FirstName = "Joe", LastName = "West" };
            //Employee employee3 = new Employee() { Id = 3, FirstName = "Brandon", LastName = "Jane" };
            //Employee employee4 = new Employee() { Id = 4, FirstName = "Gillian", LastName = "Nguyen" };
            //Employee employee5 = new Employee() { Id = 5, FirstName = "Bruce", LastName = "Kim" };
            //Employee employee6 = new Employee() { Id = 6, FirstName = "Chris", LastName = "Tran" };
            //Employee employee7 = new Employee() { Id = 7, FirstName = "Nat", LastName = "Le" };
            //Employee employee8 = new Employee() { Id = 8, FirstName = "Tina", LastName = "Park" };
            //Employee employee9 = new Employee() { Id = 9, FirstName = "Ryan", LastName = "Higa" };
            //Employee employee10 = new Employee() { Id = 10, FirstName = "Valky", LastName = "Rae" };

            //employees.Add(employee1);
            //employees.Add(employee2);
            //employees.Add(employee3);
            //employees.Add(employee4);
            //employees.Add(employee5);
            //employees.Add(employee6);
            //employees.Add(employee7);
            //employees.Add(employee8);
            //employees.Add(employee9);
            //employees.Add(employee10);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.FirstName);
            //}
            //Console.ReadLine();

            // 3. Using foreach loop, create new list of all employees with first name "joe" in comparison statement
            // Reference property of the object you're checking


            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }

            // 4. Perform same action again using Lambda
            List<Employee> JoeList1 = employees.Where(x => x.FirstName == "Joe").ToList();
            // 5. Make list of employees with ID number greater than 5
            List<Employee> JoeList2 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in JoeList2)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.ReadLine();
        }
    }
}
