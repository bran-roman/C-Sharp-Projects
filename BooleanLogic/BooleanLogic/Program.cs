using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            // Asks for Age 
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            // Converts string to Int
            int userAge = Convert.ToInt32(Age);
            // Means user is old enough if userAge is over 15
            bool oldEnough = (userAge > 15);

            // Asks if user had DUI
            Console.WriteLine("Have you ever had a DUI?");
            string response = Console.ReadLine();
            // Converts string to Boolean
            bool Dui = Convert.ToBoolean(response);
            // Means "true" if response is either "true" or false" 
            bool noDui = (true && (true || false));

            // Asks for number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            // Converts string to Int
            int tickets = Convert.ToInt32(speeding);

            // Asks if user is qualified for insurance
            Console.WriteLine("Qualified?");
            // Says user is qualified if user is "old enough" and has "noDui" and has less than 4 "tickets")
            bool isQualified = (oldEnough && noDui && tickets < 4);
            // Returns "true" IF previous bool is true
            Console.WriteLine(isQualified);
            Console.ReadLine();
           
        }
    }
}
