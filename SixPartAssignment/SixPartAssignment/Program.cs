using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main()
        {
            // Part One Assignment

            // 1. One-Dimensional Array of Strings
            string[] messages = { "Hey there, ", "You see them? That's ", "Oh wow, it's " };

            // 2. Asks user to input text
            Console.WriteLine("Please input some text, preferably your name.");
            string userInput = Console.ReadLine();

            // 3. Loop iterating through each string + adding userInput to end of each
            for (int m = 0; m < messages.Length; m++)
            {
                messages.Append(userInput);
                Console.WriteLine("Thank you. We've added your input to our string.");
            }
            Console.ReadLine();

            for (int m = 0; m < messages.Length; m++)
            {
                
                Console.WriteLine(messages[m] + userInput);
                Console.ReadLine();
    
            }
            

            //if (messages[m] == "Hey there, ")
            //{
            //    Console.WriteLine(messages[m] + userInput);

                //}
                //for (int m=0; m < messages.Length; m)
                //Console.ReadLine();


        }
            
    }
}



            //// Asks user to select index of array using numbers 0-2
            //Console.WriteLine("Please select an index of the Array using numbers 0-2.");
            //int indexNum = Convert.ToInt32(Console.ReadLine());
            //bool arrayNum = indexNum <= 2;
            ////// Do this loop, then depending on user input, returns stringArray
            //do
            //{
            //    switch (indexNum)
            //    {
            //        // If user inputs 0, returns stringArray[0]
            //        case 0:
            //            Console.WriteLine(stringArray[0]);
            //            Console.ReadLine();
            //            arrayNum = true;
            //            break;
            //        // If user inputs 1, returns stringArray[1]
            //        case 1:
            //            Console.WriteLine(stringArray[1]);
            //            Console.ReadLine();
            //            arrayNum = true;
            //            break;
            //        // If user inputs 2, returns stringArray[2]
            //        case 2:
            //            Console.WriteLine(stringArray[2]);
            //            Console.ReadLine();
            //            arrayNum = true;
            //            break;
            //        // If user inputs any other number, returns message
            //        default:
            //            // 3. Displays message when user selects invalid index
            //            Console.WriteLine("Array number not valid. Please select a number between 0-2.");
            //            indexNum = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            // Returns message after previous sequence loop
            //while (!arrayNum);
            //Console.WriteLine("Thank you for picking a valid string. Let's move on.");
            //Console.ReadLine();

            //// 2. One-Dimensional Array of Integers
            //int[] intArray = new int[3];
            //intArray[0] = 0;
            //intArray[1] = 1;
            //intArray[2] = 2;

            //// Asks user to select index of array using numbers 0-2
            //Console.WriteLine("Please select an index of the Array u sing numbers 0-2");
            //int intNum = Convert.ToInt32(Console.ReadLine());
            //bool intIndex = intNum <= 2;

            //// Goes through loop
            //do
            //{
            //    switch (intNum)
            //    {
            //        // If user inputs 0, returns intArray[0]
            //        case 0:
            //            Console.WriteLine("The value in index 0 is: " + intArray[0]);
            //            Console.ReadLine();
            //            intIndex = true;
            //            break;
            //        // If user inputs 1, returns intArray[1]
            //        case 1:
            //            Console.WriteLine("The value in index 1 is: " + intArray[1]);
            //            Console.ReadLine();
            //            intIndex = true;
            //            break;
            //        // If user inputs 2, returns intArray[2]
            //        case 2:
            //            Console.WriteLine("The value in index 2 is: " + intArray[2]);
            //            Console.ReadLine();
            //            intIndex = true;
            //            break;
            //        // If user inputs any other number, returns message
            //        default:
            //            // 3. Displays message when user selects invalid index
            //            Console.WriteLine("Array number not valid. Please select a number between 0-2.");
            //            intNum = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!intIndex);
            //Console.WriteLine("Great, let's move on");
            //Console.ReadLine();

            //// 4. List of Strings
            //List<string> intList = new List<string>();
            //intList.Add("Hey there");
            //intList.Add("Broman");
            //intList.Add("What's up?");

            //// Asks user to select index of array using numbers 0-2
            //Console.WriteLine("Please select an index of the list using numbers 0-2");
            //int listNum = Convert.ToInt32(Console.ReadLine());
            //bool indexList = listNum <= 2;

            ////// Do this loop, then depending on user input, returns intList
            //do
            //{
            //    switch (listNum)
            //    {
            //        case 0:
            //            Console.WriteLine(intList[0]);
            //            Console.ReadLine();
            //            indexList = true;
            //            break;
            //        case 1:
            //            Console.WriteLine(intList[1]);
            //            Console.ReadLine();
            //            indexList = true;
            //            break;
            //        case 2:
            //            Console.WriteLine(intList[2]);
            //            Console.ReadLine();
            //            indexList = true;
            //            break;
            //        default:
            //            Console.WriteLine("Index doesn't exist. Try again.");
            //            listNum = Convert.ToInt32(Console.ReadLine());
//                        break;
//                }
//            }
//            while (!indexList);
//            Console.WriteLine("Thank you. We've reached the end of this program.");
//            Console.ReadLine();
//        }
//    }
//}
