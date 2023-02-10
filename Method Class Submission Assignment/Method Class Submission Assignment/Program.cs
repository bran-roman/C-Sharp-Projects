using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Submission_Assignment
{
    class Program
    {
        public class MethodClass
        {
            // 1. Create a class that takes in two integers as parameters
            public void GetSum(int x, out int y)
            {
                int input = x;
                y = input + 1;

            }
            // Another way to complete 1 *for my own knowledge*
            public void GetSum(int x, int y)
            {
                Console.WriteLine(y);
                Console.ReadLine();
            }
        }


        public static void Main(string[] args)
        {
            // 2. Instantiate the class
            var McClass = new MethodClass();
            int input = 1;
            int result = input + 1;
            Console.WriteLine("Result of " + result + " is input " + input + " + 1 ");
            Console.ReadLine();

            // 3. Call method in class, passing in two numbers
            McClass.GetSum(input, result);

            // 4. Call method in class, specifying parameters by name
            McClass.GetSum(x:input , y: out result);
            
            
        }
    }
}
