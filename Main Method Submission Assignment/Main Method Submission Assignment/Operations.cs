using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Submission_Assignment
{
    public class Operations
    {
        // 1. Create class that'll take in an integer, create a math operation, then return answer as integer
        public int Add(int i)
        {
            int input = i;
            return input + input;
        }

        // 3. Add a second method to the class with same name that'll take in a decimal, create a different math operation for it, then return answer as integer
        public int Add (decimal d)
        {
            decimal input = d;
            int decInput = Convert.ToInt32(input);
            return decInput * decInput;
        }

        // 5. Add third method with same name that'll take in a string, convert it to an integer if possible, and do different math operation on
        public int Add (string s)
        {
            string input = s;
            int strInput = Convert.ToInt32(input);
            return strInput / strInput;
        }
    }
}


//namespace CallingMethodsSubmission
//{
//    class Program
//    {
//        public int Data { get; set; }
//        static void Main(string[] args)
//        {

//            // 2. Asks user what number they want to do the math operations on
//            Console.WriteLine("Pick a number to perform math operations on.");
//            int askNum = Convert.ToInt32(Console.ReadLine());

//            // 3. Call each method in turn, passing user input to method + Display returned integer to screen
//            var operatorObject = new CreatedClassOne();
//            var addResult = operatorObject.Add(askNum);
//            var subResult = operatorObject.Subtract(askNum);
//            var divResult = operatorObject.Divide(askNum);

//            // Prints results using each method
//            Console.WriteLine("You picked: " + askNum);
//            Console.WriteLine("Adding 2 to " + askNum + " is: " + addResult);
//            Console.WriteLine("Subtracting 2 by " + askNum + " is: " + subResult);
//            Console.WriteLine("Dividing " + askNum + " by 2 is: " + divResult);

//            Console.ReadLine();
//        }

//    }
//}

//namespace CallingMethodsSubmission
//{
//    // 1. Create class w/ 3 methods, each will take an integer and return an integer based on math operation
//    public class CreatedClassOne
//    {
//        // Constructor: Value assigned to object upon creation
//        public int Add(int data)
//        {
//            return data + 2;
//        }
//        public int Subtract(int data)
//        {
//            return data - 2;
//        }
//        public int Divide(int data)
//        {
//            return data / 2;
//        }
//    }
//}