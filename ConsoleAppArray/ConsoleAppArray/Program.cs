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
            bool arrayNum = indexNum <= 2;
            //// Do this loop, then depending on user input, returns stringArray
            do
            {
                switch (indexNum)
                {
                    // If user inputs 0, returns stringArray[0]
                    case 0:
                        Console.WriteLine(stringArray[0]);
                        Console.ReadLine();
                        arrayNum = true;
                        break;
                    // If user inputs 1, returns stringArray[1]
                    case 1:
                        Console.WriteLine(stringArray[1]);
                        Console.ReadLine();
                        arrayNum = true;
                        break;
                    // If user inputs 2, returns stringArray[2]
                    case 2:
                        Console.WriteLine(stringArray[2]);
                        Console.ReadLine();
                        arrayNum = true;
                        break;
                    // If user inputs any other number, returns message
                    default:
                        // 3. Displays message when user selects invalid index
                        Console.WriteLine("Array number not valid. Please select a number between 0-2.");
                        indexNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // Returns message after previous sequence loop
            while (!arrayNum);
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
            bool intIndex = intNum <= 2;

            // Goes through loop
            do
            {
                switch (intNum)
                {
                    // If user inputs 0, returns intArray[0]
                    case 0:
                        Console.WriteLine("The value in index 0 is: " + intArray[0]);
                        Console.ReadLine();
                        intIndex = true;
                        break;
                    // If user inputs 1, returns intArray[1]
                    case 1:
                        Console.WriteLine("The value in index 1 is: " + intArray[1]);
                        Console.ReadLine();
                        intIndex = true;
                        break;
                    // If user inputs 2, returns intArray[2]
                    case 2:
                        Console.WriteLine("The value in index 2 is: " + intArray[2]);
                        Console.ReadLine();
                        intIndex = true;
                        break;
                    // If user inputs any other number, returns message
                    default:
                        // 3. Displays message when user selects invalid index
                        Console.WriteLine("Array number not valid. Please select a number between 0-2.");
                        intNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!intIndex);
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
            bool indexList= listNum <= 2;

            //// Do this loop, then depending on user input, returns intList
            do
            {
                switch (listNum)
                {
                    case 0:
                        Console.WriteLine(intList[0]);
                        Console.ReadLine();
                        indexList = true;
                        break;
                    case 1:
                        Console.WriteLine(intList[1]);
                        Console.ReadLine();
                        indexList = true;
                        break;
                    case 2:
                        Console.WriteLine(intList[2]);
                        Console.ReadLine();
                        indexList = true;
                        break;
                    default:
                        Console.WriteLine("Index doesn't exist. Try again.");
                        listNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!indexList);
            Console.WriteLine("Thank you. We've reached the end of this program.");
            Console.ReadLine();
        }
    }
}
