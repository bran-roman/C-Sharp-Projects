using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        public class ClassSub
        {
            // 1. Create a class that takes in two integers as parameters
            public void OutInt(int x, out int result)
            {
                int data = x;
                result = data / 2;
            }
            // 4. Create method with output parameters
            public void GetOutput(out int x, out int y)
            {
                x = 1;
                y = 2;
            }
            // 5. Overload a method
            public void GetOutput(int x)
            {
                int data = 1;
                x = data;
                
            }
        }

        // 6. Declare a class to be static
        public static void Main(string[] args)
        {
            // 2. Instatiate that class
            var cs = new ClassSub();

            // 3. Have user enter number, Call method on that number, display the output to the screen
            // should be the entered number, divided by two
            
            // Asks user for number to divide
            Console.WriteLine("Please enter a number to divide by two.");
            // Converts response to int
            int callNum = Convert.ToInt32(Console.ReadLine());
            // Calls method on number callNum + outputs as int result
            cs.OutInt(callNum, out int result);
            // Prints statement 
            Console.Write("Your input " + callNum + " divided by 2 is: " + result);
            Console.ReadLine();

        }
    }
}
