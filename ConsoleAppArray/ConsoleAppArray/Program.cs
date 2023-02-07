using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main()
        {
            // 1. One-Dimensional Array of Strings
            string[] stringArray = new string[3];
            stringArray[0] = "This is the first index string of the Array";
            stringArray[1] = "This is the second index string of the Array";
            stringArray[2] = "This is the third index string of the Array";

            // Asks user to select index of array using numbers 0-2
            Console.WriteLine("Please select an index of the Array using numbers 0-2.");
            int indexNum = Convert.ToInt32(Console.ReadLine());

            if (indexNum > stringArray.Length - 1 || indexNum < 0) // invalid index
            {
                Console.WriteLine("Array number not valid.");
            }
            else // index is valid
            {
                Console.WriteLine("The element at index " + indexNum + " is: " + stringArray[indexNum]);
                Console.WriteLine("Thank you for picking a valid string. Let's move on.");

            }

            

            // 2. One-Dimensional Array of Integers
            int[] intArray = new int[3];
            intArray[0] = 0;
            intArray[1] = 1;
            intArray[2] = 2;

            // Asks user to select index of array using numbers 0-2
            Console.WriteLine("Please select an index of the Array using numbers 0-2");
            int intNum = Convert.ToInt32(Console.ReadLine());
            
            if (intNum > stringArray.Length-1 || intNum < 0) // invalid string
            {
                Console.WriteLine("Array number not valid.");
            }
            else // index is valid
            {
                Console.WriteLine("The element at index " + intNum + " is: " + intArray[intNum]);
                Console.WriteLine("Great, let's move on");

            }
            

            // 4. List of Strings
            List<string> intList = new List<string>();
            intList.Add("Hey there");
            intList.Add("Broman");
            intList.Add("What's up?");

            // Asks user to select index of array using numbers 0-2
            Console.WriteLine("Please select an index of the list using numbers 0-2");
            int listNum = Convert.ToInt32(Console.ReadLine());
            if (listNum > intList.Count - 1 || listNum < 0) // invalid string
            {
                Console.WriteLine("Array number not valid.");
            }
            else // index is valid
            {
                Console.WriteLine("The element at index " + listNum + " is: " + intList[listNum]);

            }
            
            Console.ReadLine();
        }
    }
}
