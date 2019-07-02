using System;
using System.Collections.Generic;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo UI = Questions();
            Console.WriteLine("Do you have any pets?");
            string response = Console.ReadLine();
            List<string> petNames = new List<string>();
            while (response.ToLower() == "yes")
            {
                Console.WriteLine("What is the name of one of your pets?");
                string petName = Console.ReadLine();
                petNames.Add(petName);
                Console.WriteLine("Do you have any more pets?");
                response = Console.ReadLine();
            }
            Answers(UI);
            if (petNames.Count == 0)
            {
                Console.WriteLine("You do not have any animal companions.");
            }
            else
            {
                foreach (string petName in petNames)
                {
                    Console.WriteLine(petName + " is a loyal companion of yours.");
                }
            }
        }

        static UserInfo Questions()
        {
            UserInfo You = new UserInfo();
            Console.WriteLine("What is your first name?");
            You.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            You.LastName = Console.ReadLine();
            You.FavoriteNumber = GetIntFromUser("What is your favorite number?");
            return You;
        }

        static int GetIntFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        static void Answers(UserInfo UI)
        {
            Console.WriteLine("Hello, " + UI.FirstName + " " + UI.LastName + "!");
            Console.WriteLine("Your favorite number is " + UI.FavoriteNumber + "!");
        }
    }
    class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FavoriteNumber { get; set; }
    }
}
