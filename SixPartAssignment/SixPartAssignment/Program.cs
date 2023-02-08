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


            for (int m = 0; m < messages.Length; m++)
            {
                // Adds user input to current data at index "m" in array
                messages[m] = messages[m] + userInput;
                // Displays input
                Console.WriteLine(messages[m]);
                Console.ReadLine();
            }

            // Part Two Assignment

            // 1. / 2. Add infinite loop + Save code

            // Asks user to enter integer
            Console.WriteLine("Enter an integer: ");
            // Converts user response to Int
            int intNum = Convert.ToInt32(Console.ReadLine());
            // Converts int to Boolean
            bool intDoubleNum = Convert.ToBoolean(intNum);


            do
            {
                Console.WriteLine("The double of " + intNum + " is " + intNum * 2);

            }

            // 3. Fix infinite loop so that it will execute properly


            // When true, print this message (infinite loop)
            // Adding ! to "intDoubleNum" to execute while statement, followed by "Console.ReadLine()" to pause console
            while (!intDoubleNum);
            {
                Console.WriteLine("Great, let's move on.");
            }
            Console.ReadLine();

            // Part Three Assignment
            // 1. Add loop where "<" operator is the comparison used to determine whether to continue iterating loop
            List<int> finalScores = new List<int>();
            finalScores.Add(97);
            finalScores.Add(86);
            finalScores.Add(30);
            finalScores.Add(25);
            finalScores.Add(99);
            finalScores.Add(87);

            // For each score, if score > 85, then print if statement
            Console.WriteLine("Here are the final test scores: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(finalScores[i]);
            }

            // 3. Add another loop where "<=" is the comparison operator
            // For each failScore, if failScore <= 84, print if statement
            Console.WriteLine("Here are the failing test scores: ");
            for (int i = 0; i <= 5; i++)
            {
                if (finalScores[i] > 85)
                {
                    Console.WriteLine(finalScores[i]);
                }
            }
            Console.ReadLine();

            // Part Four Assignment

            // 1. Add list of strings where each item is unique
            List<string> pokeList = new List<string>();
            pokeList.Add("Charmander");
            pokeList.Add("Bulbasaur");
            pokeList.Add("Squirtle");

            // 2. Ask user to input text to search for in the list
            // Prints message in parentheses
            Console.WriteLine("Here are three Pokemon. Pick a name of one.");


            // 3. Loop that iterates through list + displays index of list item with matching text on the screen

            string pokeSelect = Console.ReadLine();
            // 4. Add code to check if user input text not on the list

            for (int i = 0; i < pokeList.Count; i++)
            {
                if (pokeSelect == pokeList[i])
                {
                    Console.WriteLine("Match found at index number " + i);
                    break;
                }
              
            }
            if (!pokeList.Contains(pokeSelect))
            {
                Console.WriteLine("There is no matching name on this list.");
            }

            // 5. Add a code that stops loop from executing once a match has been found.
            // One loop is ran, pauses console
            Console.ReadLine();

            // Part Five Assignment

            // 1. Add list of strings with at least two identical strings in the list + ask user to select text to search for in list
            List<string> names = new List<string>() { "Brandon", "Broman", "Bruce", "Gillian", "Gillian" };
            // Prints message asking for user to input text to search for
            Console.WriteLine("Input name to search for in the names list");
            string selected = Console.ReadLine();
            // For each string name in names, perform this loop
            for (int i = 0; i < names.Count; i++)
            {
                // If name starts with "B" from user input, returns name starting with that input
                if (selected == names[i])
                {
                    Console.WriteLine("Match found at " + i);
                }
                //else
                //{
                //    Console.WriteLine("There's no name with that letter text in this list.");
                //    break;
                //}
            }
            if (!names.Contains(selected))
            {
                Console.WriteLine("There's no matching name in this list");
            }
            Console.ReadLine();

            // Part Six Assignment

            // 1.Create list of strings with at least two identical strings in list

            List<string> grades = new List<string>() { "A", "B", "C", "D", "A", "F" };
            List<string> gradesCopy = new List<string>();

            // 2. Create foreach loop that displays message showing if string has already appeared in list
            // For each grade in grades list, perform this loop
            foreach (string grade in grades)
            {
                // if gradesCopy list contains "grade", print if statement
                if (gradesCopy.Contains(grade))
                {
                    Console.WriteLine(grade + " has occured before");
                }
                // if gradesCopy list doesn't contain "grade", print else statement
                else
                {
                    Console.WriteLine(grade + " has not occured before");
                }
                // Adds current item from grade list to gradesCopy. Holds copy of each previously occuring item
                gradesCopy.Add(grade);

            }
            Console.ReadLine();
        }
    }
}


