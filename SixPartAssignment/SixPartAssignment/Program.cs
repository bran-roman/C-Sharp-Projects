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
            }

            for (int m = 0; m < messages.Length; m++)
            {

                Console.WriteLine(messages[m] + userInput);
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
            foreach (int score in finalScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }
            Console.ReadLine();

            // 3. Add another loop where "<=" is the comparison operator
            // For each failScore, if failScore <= 84, print if statement
            foreach (int failScore in finalScores)
            {
                if (failScore <= 84)
                {
                    Console.WriteLine("Your score of: " + failScore + " did not pass.");
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
            Console.WriteLine("Here are three Pokemon. Pick a number between 0-2 to choose your starter.");


            // 3. Loop that iterates through list + displays index of list item with matching text on the screen

            int pokeSelect = Convert.ToInt32(Console.ReadLine());
            // 4. Add code to check if user input text not on the list

            // If selected number is greater than the number of indexes - 1 OR if selected number is less than 0, print this if statement
            if (pokeSelect > pokeList.Count - 1 || pokeSelect < 0) // invalid string
            {
                Console.WriteLine("You didn't choose a valid number. Guess you don't want a Pokemon..");
            }
            else
            {
                Console.WriteLine("You've selected: " + pokeSelect + ", so you're Pokemon is " + pokeList[pokeSelect]);
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


