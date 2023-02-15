using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prints current date/time to console
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            // 2. Asks user for a number + returns user response as int
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // 3. Prints to console the exact time in X hours, X being the number the user entered
            DateTime futureTime = now.AddHours(userNum);
            // Returns DateTime futureTime
            Console.WriteLine(futureTime);
            Console.ReadLine();
        }
    }
}
