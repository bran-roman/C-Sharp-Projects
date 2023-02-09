using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {

            // 2. Asks user what number they want to do the math operations on
            Console.WriteLine("Pick a number to perform math operations on.");
            int askNum = Convert.ToInt32(Console.ReadLine());

            // 3. Call each method in turn, passing user input to method + Display returned integer to screen
            var operatorObject = new CreatedClassOne();
            var addResult = operatorObject.Add(askNum);
            var subResult = operatorObject.Subtract(askNum);
            var divResult = operatorObject.Divide(askNum);

            // Prints results using each method
            Console.WriteLine("You picked: " + askNum);
            Console.WriteLine("Adding 2 to " + askNum + " is: " + addResult);
            Console.WriteLine("Subtracting 2 by " + askNum + " is: " + subResult);
            Console.WriteLine("Dividing " + askNum + " by 2 is: " + divResult);
            
            Console.ReadLine();
        }

    }
}
