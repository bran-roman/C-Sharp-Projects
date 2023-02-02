using System;

namespace MathComp
{
    class Program
    {
        static void Main()
        {
            // Intro message
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Getting Person 1's information
            Console.WriteLine("Person 1, please enter the following:");
            Console.ReadLine();

            // Converts response to string
            Console.WriteLine("What is your hourly rate?");
            string hrRate = Console.ReadLine();
            Console.WriteLine("What are your hours worked per week?");
            string hrsWorked = Console.ReadLine();

            // Getting Person 2's information
            Console.WriteLine("Person 2, please enter the following:");
            Console.ReadLine();

            // Converts response to string
            Console.WriteLine("What is your hourly rate?");
            string hrRate2 = Console.ReadLine();
            Console.WriteLine("What are your hours worked per week?");
            string hrsWorked2 = Console.ReadLine();

            // Getting Annual Salary of Person 1

            // Converts strings to int
            int hourRate1 = Convert.ToInt32(hrRate);
            int hourWorked1 = Convert.ToInt32(hrsWorked);
            // Multiples hourly rate by hours worked
            int weeklyPay1 = hourRate1 * hourWorked1;
            // Multiplies weekly pay by number of weeks in a year (52)
            int salary1 = weeklyPay1 * 52;
            // Converts int to String
            string annualSalary1 = Convert.ToString(salary1);
            // Prints Annual Salary of Person 1 Result
            Console.WriteLine("Annual salary of Person 1:" + annualSalary1);
            Console.ReadLine();

            // Getting Annual Salary of Person 2

            // Converts string to int
            int hourRate2 = Convert.ToInt32(hrRate2);
            int hourWorked2 = Convert.ToInt32(hrsWorked2);
            // Multiples hourly rate by hours worked
            int weeklyPay2 = hourRate2 * hourWorked2;
            // Multiples weekly pay by number of weeks in a year (52)
            int salary2 = weeklyPay2 * 52;
            // Converts int to String
            string annualSalary2 = Convert.ToString(salary2);
            // Prints Annual Salary of Person 2 Result
            Console.WriteLine("Annual salary of Person 2:" + annualSalary2);
            Console.ReadLine();

            // Asks if Person 1 makes more money than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            string makesMore = Console.ReadLine();
            // If "yes," then response = true
            bool yes = salary1 > salary2;
            // Returns "true" or "false"
            Console.WriteLine(yes.ToString());
            Console.ReadLine();

        }
    }
}
