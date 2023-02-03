using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            // Prints introduction message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            // Prints message, then converts response to int "pckgWeight"
            Console.WriteLine("Please enter the weight of the package you're shipping.");
            int pckgWeight = Convert.ToInt32(Console.ReadLine());

            // If response "pckgWeight" is over 50, program prints message in braces
            if (pckgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Prints message, then converts response to int "pckgWidth"
                Console.WriteLine("Please enter the width of the package.");
                int pckgWidth = Convert.ToInt32(Console.ReadLine());

                // Prints message, then converts response to int "pckgHeight"
                Console.WriteLine("Please enter the height of the package.");
                int pckgHeight = Convert.ToInt32(Console.ReadLine());

                // Prints message, then converts response to int "pckgLength"
                Console.WriteLine("Please enter the length of the package.");
                int pckgLength = Convert.ToInt32(Console.ReadLine());

                // If total of pckgWidth, pckgHeight and pckgLength is greater than 50, prints message in braces 
                if (pckgWidth + pckgHeight + pckgLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }

                else
                {
                    // dimensions = width multiplied by height multiplied  by length
                    int dimensions = pckgWidth * pckgHeight * pckgLength;
                    // dimWeight = dimensions multiplied by weight
                    int dimWeight = dimensions * pckgWeight;
                    // result = dimWeight divided by 100
                    int result = dimWeight / 100;
                    // Prints message, followed by the result int
                    Console.WriteLine("Your estimated total for shipping this package is: $" + result);
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();

        }
    }
}
