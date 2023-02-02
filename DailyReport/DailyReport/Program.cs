using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {   // Prints "The Tech Academy"
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();

            // Prints "Student Daily Report"
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            // Prints "What is your name?"
            Console.WriteLine("What is your name?");
            // Turns typed response into string "yourName"
            string yourName = Console.ReadLine();
            // Prints message including previous string
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            // Prints "What course are you on?"
            Console.WriteLine("What course are you on?");
            // Turns response into string "courseName"
            string courseName = Console.ReadLine();
            // Prints message with previous string
            Console.WriteLine("Your course name is " + courseName);
            Console.ReadLine();

            // Prints "What page number?"
            Console.WriteLine("What page number?");
            // Turns response into string
            string pageNumber = Console.ReadLine();
            // Converts previous string to integer
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("You are on page " + pageNum);
            Console.ReadLine();

            // Prints parentheses question
            Console.WriteLine("Do you need help with anything else? Please answer \"true\" or \"false\".");
            // Turns response into string
            string needHelp = Console.ReadLine();
            // Converts string to bool
            bool stillNeedHelp = Convert.ToBoolean(needHelp);
            Console.WriteLine("You selected " + stillNeedHelp);
            Console.ReadLine();

            // Prints parentheses question
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Thanks for letting us know.");
            Console.ReadLine();

            // Prints parentheses question
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("Thanks for sharing your feedback!");
            Console.ReadLine();

            // Prints parentheses question
            Console.WriteLine("How many hours did you study today");
            // Turns response into string
            string studyHours = Console.ReadLine();
            // Converts string to Int
            int studiedHours = Convert.ToInt32(studyHours);
            Console.WriteLine("Hours you studied for: " + studiedHours);
            Console.ReadLine();
            

            // Prints "The Tech Academy"
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

