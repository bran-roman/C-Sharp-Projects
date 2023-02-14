using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    // 1. Create an Employee Class with Id, FirstName and LastName properties
    public class Employee
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<string> Employees { get; set; }
        public virtual void ListEmployees()
        {
            foreach (string employee in Employees)
            {
                Employees.Add(FirstName);
                Employees.Add(LastName);
                Employees.Add(Convert.ToString(Id));
                Console.WriteLine(FirstName + LastName + Id);
                Console.ReadLine();
            }
        }
        // 2. Overlaod "==" operator so it checks if two employee objects are equal by comparing their ID
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
                return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        public override bool Equals(object obj)
        {
            Employee employee1 = obj as Employee;

            if (employee1 == null)
            {
                return false;
            }

            return this.Id.Equals(employee1.Id);

        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract_Class_Submission_Assignment
//{
//    public class Program
//    {
//        static public void Main(string[] args)
//        {
//            // 5. Inside main method, instantiate employee object with firstName "Sample" and lastName "Student"
//            Employee employee = new Employee() { FirstName = "Sample", LastName = " Student" };
//            employee.Employees = new List<string>() { "Sample" + "Student" };

//            // Call SayName() method on the object
//            employee.SayName();
//            Console.ReadLine();

//            // 3. Use polymorphism to create an object of type IQuittable + call Quit() method on it
//            IQuittable quittable = new Employee();
//            try
//            {
//                quittable.Quit(employee);
//            }
//            catch (NotImplementedException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract_Class_Submission_Assignment
//{
//    // 3. Create another class Employee + inherit from Person Class
//    public class Employee : Person, IQuittable
//    {
//        public virtual List<string> Employees { get; set; }

//        // 4. Implement SayName inside of Employee class
//        public override void SayName()
//        {

//            foreach (string employee in Employees)
//            {
//                // throw new NotImplementedException();
//                Console.WriteLine("Name: " + FirstName + LastName);

//            }


//        }

//        // 2. Have employee class inherit interface + implement Quit() method
//        public void Quit(Employee employee)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract_Class_Submission_Assignment
//{
//    // 1. Create abstract class called Person with firstName and lastName strings
//    public abstract class Person
//    {
//        public List<string> Persons { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        // 2. Give it the method SayName()
//        public virtual void SayName()
//        {
//            throw new NotImplementedException();

//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract_Class_Submission_Assignment
//{
//    public class Program
//    {
//        static public void Main(string[] args)
//        {
//            // 5. Inside main method, instantiate employee object with firstName "Sample" and lastName "Student"
//            Employee employee = new Employee() { FirstName = "Sample", LastName = " Student" };
//            employee.Employees = new List<string>() { "Sample" + "Student" };

//            // Call SayName() method on the object
//            employee.SayName();
//            Console.ReadLine();

//            // 3. Use polymorphism to create an object of type IQuittable + call Quit() method on it
//            IQuittable quittable = new Employee();
//            try
//            {
//                quittable.Quit(employee);
//            }
//            catch (NotImplementedException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstract_Class_Submission_Assignment
//{
//    // 3. Create another class Employee + inherit from Person Class
//    public class Employee : Person, IQuittable
//    {
//        public virtual List<string> Employees { get; set; }

//        // 4. Implement SayName inside of Employee class
//        public override void SayName()
//        {

//            foreach (string employee in Employees)
//            {
//                // throw new NotImplementedException();
//                Console.WriteLine("Name: " + FirstName + LastName);

//            }


//        }

//        // 2. Have employee class inherit interface + implement Quit() method
//        public void Quit(Employee employee)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
