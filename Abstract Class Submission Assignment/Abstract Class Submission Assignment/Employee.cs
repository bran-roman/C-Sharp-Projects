using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
    // 3. Create another class Employee + inherit from Person Class
    public class Employee : Person, IQuittable
    {
        public virtual List<string> Employees { get; set; }

        // 4. Implement SayName inside of Employee class
        public override void SayName()
        {

            foreach (string employee in Employees)
            {
                // throw new NotImplementedException();
                Console.WriteLine("Name: " + FirstName + LastName);

            }


        }
        
        // 2. Have employee class inherit interface + implement Quit() method
        public void Quit(Employee employees)
        {
            throw new NotImplementedException();
        }
    }
}
