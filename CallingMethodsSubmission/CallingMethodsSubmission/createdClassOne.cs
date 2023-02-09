using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    // 1. Create class w/ 3 methods, each will take an integer and return an integer based on math operation
    public class CreatedClassOne
    {
        // Constructor: Value assigned to object upon creation
        public int Add(int data)
        {
            return data + 2;
        }
        public int Subtract(int data)
        {
            return data - 2;
        }
        public int Divide(int data)
        {
            return data / 2;
        }
    }
}
