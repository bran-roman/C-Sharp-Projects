using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 1. Create const variable
            const string newVariable = "Variable Name";

            // 2. Create variable using keyword "var"
            var x = 1;

            // 3. Chain two constructors together
            
        }
    }
    class User
    {
        public string username;
        public string location;

        // 3. Chain two constructors together
        public User(string username, string location)
        {
            this.username = username;
            this.location = location;
        }
    }
}
