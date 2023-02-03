using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int userAge = Convert.ToInt32(Age);
            bool oldEnough = (userAge > 15);

            Console.WriteLine("Have you ever had a DUI?");
            string response = Console.ReadLine();
            bool Dui = Convert.ToBoolean(response);
            bool noDui = (true && (true || false));

            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            int tickets = Convert.ToInt32(speeding);

            Console.WriteLine("Qualified?");
            bool isQualified = (oldEnough && noDui && tickets < 4);
            Console.WriteLine(isQualified);
            Console.ReadLine();
           
        }
    }
}
