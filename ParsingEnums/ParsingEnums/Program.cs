using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Wrap the above statement in a Try/Catch block 
            // and have it print message
            try
            {
                //2. Prompt user to enter current day of the week

                // Prints statement asking for user to input day
                Console.WriteLine("Please enter the current day of the week");
                // Converts user response to var
                var currentDay = Console.ReadLine();
                Days day;

                // If Enum Parses enum "Days" with these params, prints if statement
                if (Enum.TryParse<Days>(currentDay, out day))
                {
                    Console.WriteLine("Nice, today is " + currentDay);
                    Console.ReadLine();
                }
                // If user enters invalid input, throws exception in else statement
                else
                {
                    throw new OverflowException(); // TryParse failed + Enum not valid
                }
            }
            // Catches exception and prints statement
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();

        }
        //1. Create Enum for days of the week
        public enum Days
        {
            // 3. Assign value to a variable of that enum data type 
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
