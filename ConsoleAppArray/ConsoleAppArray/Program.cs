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

            if (indexNum > 2 || indexNum > stringArray.Length - 1 || indexNum < 0) // invalid index
            {
                Console.WriteLine("Array number not valid. Try again.");
                indexNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The element at index " + indexNum + " is: " + stringArray[indexNum]);
                Console.ReadLine();
            }
            else // index is valid
            {
                Console.WriteLine("The element at index " + indexNum + " is: " + stringArray[indexNum]);
                Console.ReadLine();
            }
            Console.WriteLine("Thank you for picking a valid string. Let's move on.");
            Console.ReadLine();

            // 2. One-Dimensional Array of Integers
            int[] intArray = new int[3];
            intArray[0] = 0;
            intArray[1] = 1;
            intArray[2] = 2;

            // Asks user to select index of array using numbers 0-2
            Console.WriteLine("Please select an index of the Array u sing numbers 0-2");
            int intNum = Convert.ToInt32(Console.ReadLine());
            
            if (intNum > 2 || intNum > stringArray.Length-1) || indexNum < 0) // invalid string
            {
                Console.WriteLine("Array number not valid. Try again.");
                intNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The element at index " + intNum + " is: " + intArray[intNum]);
                Console.ReadLine();
            }
            else // index is valid
            {
                Console.WriteLine("The element at index " + intNum + " is: " + intArray[intNum]);
                Console.ReadLine();
            }
            Console.WriteLine("Great, let's move on");
            Console.ReadLine();

            // 4. List of Strings
            List<string> intList = new List<string>();
            intList.Add("Hey there");
            intList.Add("Broman");
            intList.Add("What's up?");

            // Asks user to select index of array using numbers 0-2
            Console.WriteLine("Please select an index of the list using numbers 0-2");
            int listNum = Convert.ToInt32(Console.ReadLine());
            if (listNum > 2 || listNum > intList.Count - 1 || indexNum < 0) // invalid string
            {
                Console.WriteLine("Array number not valid. Try again.");
                listNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The element at index " + listNum + " is: " + intList[listNum]);
                Console.ReadLine();
            }
            else // index is valid
            {
                Console.WriteLine("The element at index " + listNum + " is: " + intList[listNum]);
                Console.ReadLine();
            }
            Console.WriteLine("Great, we're all set!");
            Console.ReadLine();
        }
    }
}
