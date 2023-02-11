using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Submission
{
    // 1. Create class called person with two string properties FirstName and LastName
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        // 2. Give class void method SayName() w/ no parameters which prints full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
