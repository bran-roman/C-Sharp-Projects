using System;


namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main()
        {
            // Prints message, then converts response into Int
            Console.WriteLine("Guess my favorite number.");
            int number = Convert.ToInt32(Console.ReadLine());
            // boolean guessFav is true if number guessed is equal to 4
            bool guessFav = number == 4;

            while (!guessFav)
            {
                switch (number)
                {
                    case 10:
                        // If number guessed is 10, prints following message, then converts next response into Int
                        Console.WriteLine("Wrong, my number is lower. Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        // If number guessed is 2, prints following message, then converts next response into Int
                        Console.WriteLine("Wrong, my number is higher.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        // If number guessed is 4, prints following message
                        Console.WriteLine("Dang, how'd you know?!");
                        guessFav = true;
                        break;
                    default:
                        // If number guessed is not one of previous cases, prints following message, then converts next response into Int
                        Console.WriteLine("Wrong, try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            // Prints message, then converts response to Int
            Console.WriteLine("Okay, now guess my Mom's favorite number.");
            int nextNum = Convert.ToInt32(Console.ReadLine());
            // boolean momFav is true if number guessed (nextNum) is equal to 8
            bool momFav = nextNum == 8;

            // Do this loop, repeats case sequences, then moves to while loop
            do
            {
                switch (nextNum)
                {
                    case 24:
                        // If number guessed is 24, prints following message, then converts next response into Int
                        Console.WriteLine("Wrong, the number is lower. Guess again.");
                        nextNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        // If number guessed is 1, prints following message, then converts next response into Int
                        Console.WriteLine("Wrong, the number is higher. Guess again.");
                        nextNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        // If number guessed is 8, prints following message
                        Console.WriteLine("Dang, how'd you know?!");
                        momFav = true;
                        break;
                    default:
                        // If number guessed is not one of previous cases, prints following message, then converts next response into Int
                        Console.WriteLine("Wrong, try again");
                        nextNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!momFav);

            Console.WriteLine("You guessed right. Good job!");
            Console.Read();

        }
    }
}