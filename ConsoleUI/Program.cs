using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SayAuthor();
            string firstName = GetUsersName("What is your first name?");
            string lastName = GetUsersName("What is your last name?");
            WelcomeUser(firstName, lastName);


            Console.ReadLine();
        }

        private static void SayAuthor()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Written by Derek Sparks");
            Console.WriteLine("for the Foundation in C# course");
            Console.WriteLine("************************************");
        }

        private static void WelcomeUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello { firstName } { lastName }");
        }

        private static string GetUsersName(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();

            if (output.Length > 1)
            {
                return output;
            }
          
            return "<Input not recognized. Try again.>";
        }

    }
}
