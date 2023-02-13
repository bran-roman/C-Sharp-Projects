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

            // 3. Use polymorphism to create an object of type IQuittable + call Quit() method on it
            IQuittable quittable = new Employee();
            try
            {
                quittable.Quit(employee);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}