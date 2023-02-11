using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
    public class Program
    {
        static public void Main(string[] args)
        {
            // 5. Inside main method, instantiate employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee() { FirstName = "Sample" , LastName = " Student" };
            employee.Employees = new List<string>() { "Sample" + "Student" };

            // Call SayName() method on the object
            employee.SayName();
            Console.ReadLine();
        }
    }
}