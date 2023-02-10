using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    public class Program
    {
        public class Operations
        {
            // 1. Create a class that takes in two integers as parameters
            public int GetAdd(int x, int y = 0)
            {
                int result = x + y;
                return result;
            }
        }

        public int Input { get; set; }
        public int Value { get; set; }
        static void Main(string[] args)
        {
            var Ops = new Operations();

               
            // 2. Instantiate the class and 3. Ask user to input two numbers, one at a time (prompt them the second number is optional)
            Console.WriteLine("Please input an integer to perform math operations on.");
            int intNum = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Optional: Please input another integer to perform math operations on, otherwise press enter.");
                int intNum2 = Convert.ToInt32(Console.ReadLine());

                // 4. Call method in class, passing in the one or two numbers entered
                var result = Ops.GetAdd(intNum, intNum2);
                Console.WriteLine("The sum of " + intNum + " and " + intNum2 + " returned as an integer is: " + result);
                Console.ReadLine();
            }
            catch
            {
                var result1 = Ops.GetAdd(intNum);
                Console.WriteLine("Sum of two numbers is: " + result1);
                Console.ReadLine();
            }
        }
    }
}