using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 90, 80, 70, 60, 50, 40 };

            // Asks for user number input to divide each number in list by
            Console.WriteLine("Pick a number to divide each number in the list by.");

            try
            {
                // Converts user input to integer
                int inputNum = Convert.ToInt32(Console.ReadLine());

                // For loop goes through each item in list
                for (int i = 0; i < intList.Count - 1; i++)
                {
                    // Divides each item by the user input number, then prints message
                    int dividedNum = intList[i] / inputNum;
                    Console.WriteLine(intList[i] + " divided by " + inputNum + " is " + dividedNum);
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException)
            {
                // Prints message if user input zero number
                Console.WriteLine("Let's not divide by zero please.");
                return;
            }
            catch (FormatException)
            {
                // Prints message if user enters wrong input format
                Console.WriteLine("Let's use whole numbers and not words, please.");
                return;
            }
            catch (Exception ex)
            {
                // Prints general exception message if general error occurs
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                // Prints message after try/catch blocks have been ran
                Console.WriteLine("Program has been executed.");
                Console.ReadLine();
            }
            // Prints last message after try/catch and finally blocks
            Console.WriteLine("Thank you for your input!");
            Console.ReadLine();
        }
    }
}


//// 1. Add list of strings with at least two identical strings in the list + ask user to select text to search for in list
//List<string> names = new List<string>() { "Brandon", "Broman", "Bruce", "Gillian", "Gillian" };
//// Prints message asking for user to input text to search for
//Console.WriteLine("Input name to search for in the names list");
//            string selected = Console.ReadLine();
//            // For each string name in names, perform this loop
//            for (int i = 0; i<names.Count; i++)
//            {
//                // If name starts with "B" from user input, returns name starting with that input
//                if (selected == names[i])
//                {
//                    Console.WriteLine("Match found at " + i);
//                }
//                //else
//                //{
//                //    Console.WriteLine("There's no name with that letter text in this list.");
//                //    break;
//                //}
//            }
//            if (!names.Contains(selected))
//            {
//                Console.WriteLine("There's no matching name in this list");
//            }
//            Console.ReadLine();

//            // Part Six Assignment

//            // 1.Create list of strings with at least two identical strings in list

//            List<string> grades = new List<string>() { "A", "B", "C", "D", "A", "F" };
//List<string> gradesCopy = new List<string>();

//            // 2. Create foreach loop that displays message showing if string has already appeared in list
//            // For each grade in grades list, perform this loop
//            foreach (string grade in grades)
//            {
//                // if gradesCopy list contains "grade", print if statement
//                if (gradesCopy.Contains(grade))
//                {
//                    Console.WriteLine(grade + " has occured before");
//                }
//                // if gradesCopy list doesn't contain "grade", print else statement
//                else
//                {
//                    Console.WriteLine(grade + " has not occured before");
//                }
//                // Adds current item from grade list to gradesCopy. Holds copy of each previously occuring item
//                gradesCopy.Add(grade);

//            }
//            Console.ReadLine();