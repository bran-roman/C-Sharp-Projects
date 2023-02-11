using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
    // 1. Create abstract class called Person with firstName and lastName strings
    public abstract class Person
    {
        public List<string> Persons { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. Give it the method SayName()
        public virtual void SayName()
        {
            throw new NotImplementedException();
            
        }

    }
}
