using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenates three strings
            string greetings = "A classmate said \"Hi Broman!\" \n";
            string question = "The teacher then asked, \"Is that your real name, Broman?\" \n";
            string response = "I replied \"No, it's a mix of my first and last names. \n \t Cool right?!\" ";

            Console.WriteLine(greetings + question + response);
            Console.ReadLine();

            // String name we'll be changing
            string capThis = "let's go niners!";
            // Converts string "capThis" to Uppercase, then prints string statement
            capThis = capThis.ToUpper();
            Console.WriteLine(capThis);
            Console.ReadLine();

            // Creates Stringbuilder and builds paragraph of text, one sentence at a time
            // String we'll be changing
            StringBuilder sb = new StringBuilder("Good Morning!\n");
            
            sb.Append("Isn't it a nice day outside?\n");
            sb.Append("It's actually been pretty cold. \n To be honest I'm not used to Vegas weather being this way.\n But it's okay, we'll make the most of it!");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
