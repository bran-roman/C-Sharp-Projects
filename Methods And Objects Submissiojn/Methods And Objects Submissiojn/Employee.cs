using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Submission
{
    // 3. Create class Employee and have it inherit from Person Class
    public class Employee : Person
    {
        public List<string> Persons { get; set; }
        // Giving employee class property int ID
        public int Id { get; set; }
           
    }
}
